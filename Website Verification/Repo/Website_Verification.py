import csv
import requests
import customtkinter as ctk
from tkinter import filedialog, messagebox
import threading

ctk.set_appearance_mode("dark")
ctk.set_default_color_theme("blue")

class WebsiteCheckerApp(ctk.CTk):
    def __init__(self):
        super().__init__()

        self.title("Live Website Status Checker")
        self.geometry("600x500")

        # Header
        self.label = ctk.CTkLabel(self, text="URL Status Monitor", font=("Arial", 20, "bold"))
        self.label.pack(pady=15)

        # File Selection
        self.file_button = ctk.CTkButton(self, text="Load CSV File", command=self.select_file)
        self.file_button.pack(pady=5)

        self.path_label = ctk.CTkLabel(self, text="No file loaded", font=("Arial", 10), text_color="gray")
        self.path_label.pack(pady=5)

        # Controls
        self.run_button = ctk.CTkButton(self, text="Start Checking", command=self.start_check_thread, state="disabled")
        self.run_button.pack(pady=10)

        # Result Display Area (The "Display Only" part)
        self.result_display = ctk.CTkTextbox(self, width=550, height=200, font=("Courier New", 12))
        self.result_display.pack(pady=10, padx=20)
        self.result_display.insert("0.0", "Results will appear here...\n" + "-"*50 + "\n")
        self.result_display.configure(state="disabled") # Prevent user typing in it

        # Progress Bar
        self.progress = ctk.CTkProgressBar(self, width=550)
        self.progress.set(0)
        self.progress.pack(pady=10)

        self.selected_file = ""

    def select_file(self):
        self.selected_file = filedialog.askopenfilename(filetypes=[("CSV files", "*.csv")])
        if self.selected_file:
            self.path_label.configure(text=f"Loaded: {self.selected_file.split('/')[-1]}")
            self.run_button.configure(state="normal")

    def log_result(self, message):
        """Helper to append text to the display box"""
        self.result_display.configure(state="normal")
        self.result_display.insert("end", message + "\n")
        self.result_display.see("end") # Auto-scroll to bottom
        self.result_display.configure(state="disabled")

    def start_check_thread(self):
        # Clear previous results
        self.result_display.configure(state="normal")
        self.result_display.delete("2.0", "end")
        self.result_display.configure(state="disabled")
        
        thread = threading.Thread(target=self.run_check, daemon=True)
        thread.start()

    def run_check(self):
        self.run_button.configure(state="disabled")
        
        try:
            with open(self.selected_file, mode='r', newline='', encoding='utf-8') as file:
                rows = list(csv.DictReader(file))
                total = len(rows)
                
                for i, row in enumerate(rows):
                    url = row['url'].strip()
                    try:
                        response = requests.get(url, timeout=5)
                        status = "UP" if response.ok else f"DOWN ({response.status_code})"
                    except:
                        status = "FAILED/TIMEOUT"

                    # Display result in the UI box
                    self.log_result(f"[{i+1}/{total}] {url} -> {status}")
                    
                    # Update progress bar
                    self.progress.set((i + 1) / total)

            messagebox.showinfo("Done", "All websites have been checked.")
            
        except Exception as e:
            messagebox.showerror("Error", f"Failed to read file: {str(e)}")
        
        self.run_button.configure(state="normal")

if __name__ == "__main__":
    app = WebsiteCheckerApp()
    app.mainloop()
