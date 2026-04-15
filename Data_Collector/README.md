# 🧠💀 DATA COLLECTOR

> “If the system is running… it’s already leaving traces.”

A custom-built Windows data collection + analysis framework designed for **DFIR research, system artifact extraction, and security experimentation**.

---

## ⚙️ FEATURES

### 🔍 Volatile Data Collection
- Running processes snapshot
- Active network connections
- Logged-in user sessions
- Open files and shared resources
- System information dump
- Scheduled task enumeration
- Services mapping
- Command history extraction
- Registry persistence (Run Keys)

### 🌐 Browser Artifacts
- Microsoft Edge
- Google Chrome
- Mozilla Firefox
- Brave
- Opera

### 🧾 Event Log Collection
- Security Event Logs (full + filtered)
- Application Logs
- System Logs

### 💾 File System Artifacts
- Downloads (with Zone.Identifier check)
- Prefetch files
- Hosts file analysis

### 🔌 Device Tracking
- USB history (USBSTOR)
- Mounted devices mapping

### 📧 Email Activity (Experimental)
- Outlook artifacts
- Thunderbird profiles
- Gmail (browser-based traces)

---

## 🧬 CORE CAPABILITY

Transforms a live Windows system into a:

> ⚡ **Forensic Timeline Generator**

Collects and correlates artifacts from:
- Volatile memory sources
- Registry hives
- File system traces
- System logs

---

# 🛠️ COMMANDS USED (WITH EXPLANATION)

This section documents the native Windows commands used by the tool and what each one extracts during forensic collection.

---

## 🔹 Process Enumeration
```bash
tasklist
```
**Explanation:**  
Lists all running processes on the system, including process names and memory usage. Useful for identifying suspicious or unknown processes.

---

## 🔹 Network Activity
```bash
netstat -ano
ipconfig /displaydns
powershell Get-NetTCPConnection
```
**Explanation:**  
- `netstat -ano` → Shows active connections with associated Process IDs (PID)  
- `ipconfig /displaydns` → Displays DNS cache (recently resolved domains)  
- `Get-NetTCPConnection` → Provides detailed TCP connection info via PowerShell  

Used to detect suspicious outbound connections or malware beaconing.

---

## 🔹 User & Session Info
```bash
whoami
whoami /all
query user
set
wmic useraccount where name='%username%' get sid,status
```
**Explanation:**  
Collects current user identity, privileges, active sessions, environment variables, and user SID information.

---

## 🔹 System Information
```bash
systeminfo
wmic bios get serialnumber
wmic csproduct get name
wmic qfe list full
```
**Explanation:**  
Gathers OS version, hardware details, BIOS serial, system model, and installed patches (useful for vulnerability assessment).

---

## 🔹 Scheduled Tasks
```bash
schtasks /query /fo LIST /v
```
**Explanation:**  
Lists all scheduled tasks with full details. Often used by malware for persistence.

---

## 🔹 Services
```bash
tasklist /svc
```
**Explanation:**  
Maps running processes to Windows services. Helps identify suspicious services tied to malware.

---

## 🔹 Command History
```bash
doskey /history
```
**Explanation:**  
Retrieves command-line history from the current session. Useful for tracking attacker commands.

---

## 🔹 Registry (Persistence)
```bash
reg query HKLM\Software\Microsoft\Windows\CurrentVersion\Run
reg query HKCU\Software\Microsoft\Windows\CurrentVersion\Run
reg query HKLM\Software\WOW6432Node\Microsoft\Windows\CurrentVersion\Run
```
**Explanation:**  
Extracts startup programs configured in registry run keys. Common persistence mechanism.

---

## 🔹 USB History
```bash
reg query "HKLM\SYSTEM\CurrentControlSet\Enum\USBSTOR" /s
reg query "HKLM\SYSTEM\MountedDevices"
```
**Explanation:**  
Tracks previously connected USB devices and drive mappings. Useful for detecting data exfiltration via removable media.

---

## 🔹 Event Logs
```bash
wevtutil qe Security
wevtutil epl Security output.evtx
wevtutil epl Application output.evtx
wevtutil epl System output.evtx
```
**Explanation:**  
Extracts Windows event logs for forensic analysis, including login activity, process creation, and system events.

---

## 🔹 File Shares / Open Files
```bash
net share
net file
```
**Explanation:**  
Displays shared folders and currently open files over the network. Helps detect unauthorized access.

---

# 🌐 BROWSER ARTIFACT COLLECTION

> Extracts history data from Chromium-based and Gecko-based browsers.

## 📂 Microsoft Edge (Chromium)
```
C:\Users\<User>\AppData\Local\Microsoft\Edge\User Data\Default\History
```

## 📂 Google Chrome
```
C:\Users\<User>\AppData\Local\Google\Chrome\User Data\Default\History
```

## 📂 Brave Browser
```
C:\Users\<User>\AppData\Local\BraveSoftware\Brave-Browser\User Data\Default\History
```

## 📂 Opera
```
C:\Users\<User>\AppData\Roaming\Opera Software\Opera Stable\History
```

## 📂 Mozilla Firefox
```
C:\Users\<User>\AppData\Roaming\Mozilla\Firefox\Profiles\<Profile>\places.sqlite
```

**Explanation:**  
Browser history is stored in SQLite databases. The tool copies these files and parses:
- Visited URLs  
- Timestamps  
- Downloads  
- Search queries  

This helps reconstruct user activity and possible attack vectors.
