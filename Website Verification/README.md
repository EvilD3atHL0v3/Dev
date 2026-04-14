# Website Verification

A lightweight, automated tool designed to verify domain status and availability using the `curl` method.

## Description
This project automates the process of checking multiple website domains simultaneously. By leveraging `curl`, the script retrieves HTTP status codes and headers to ensure that the domains listed are active and responding correctly. This is particularly useful for bulk monitoring and system auditing.

## Features
* **Automated Scanning:** No need to check domains manually.
* **Bulk Processing:** Handles multiple URLs via a CSV input file.
* **Curl-Based:** Fast, reliable, and uses standard network protocols.

## Prerequisites
* A Unix-like environment (Linux, macOS, or WSL for Windows).
* `curl` installed on your system.
* A bash-compatible shell.

## How to Use

1.  **Prepare the Data:**
    Ensure you have a file named `sites.csv` in the root directory. This file acts as the container for all the websites you wish to check.
    * *Format:* One URL per line (e.g., `google.com`).

2.  **Run the Script:**
    Execute the automation script (e.g., `Website Verification.exe`). The script will iterate through every entry in `sites.csv` and output the verification results.

3.  **Review Results:**
    The terminal will display the status of each domain, or results will be saved to a log file if configured.

## Project Structure
* `sites.csv`: The input file containing the list of target websites.
* `Website Verification.exe`: The core script that performs the curl operations.
* `README.md`: Documentation for the project.
