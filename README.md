# Doctor Appointment System (Project #28) - Phase 1
**Misr University for Science & Technology (MUST)**  
**Course:** CS312 — Visual Programming / Software Project  

---

## 🏥 Overview
A modern, zero-configuration desktop application built with **C# (.NET 8 Windows Forms)** and an embedded **SQLite** database (`DoctorAppointment.db`).

### Phase 1 Features:
- 🔐 **Authentication**: SHA-256 password hashing with role-based navigation (Admin, Receptionist, Doctor).
- 👨‍⚕️ **Doctors Module**: Full CRUD, specialty filtering, real-time search, Egyptian mobile format validation, and EGP fees.
- 🧑 **Patients Module**: Full CRUD, demographic records, dynamic age computation, gender filtering, and Egyptian mobile format validation.
- ⚡ **Multithreading / Async Operations**: Non-blocking database calls using `async`/`await` and `Task.Run` with animated visual loading indicators.
- 💾 **Zero-Configuration Portable Database**: Automatic database creation and Egyptian seed data initialization on first launch without requiring SQL Server setup.

---

## 🔑 Default Credentials
| Role | Username | Password |
| :--- | :--- | :--- |
| **Admin** | `admin` | `admin123` (or `password123`) |
| **Receptionist** | `receptionist` | `password123` |
| **Doctor** | `doctor1` | `password123` |

---

## 🚀 How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/HAMZEH01A/ClinicManagementSystem.git
   ```
2. Open `ClinicManagementSystem/ClinicManagementSystem.sln` in **Visual Studio**.
3. Press <kbd>F5</kbd> (or click **▶ Start**).
   - The database (`DoctorAppointment.db`) is automatically initialized and seeded on first run!
