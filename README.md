# 🎓 Campus Event Management System – User Application

## 📌 Overview
This is the **User (Student) Application** of the Campus Event Management System.

It is built using **Blazor WebAssembly Standalone** and connected to **Firebase Firestore** for real-time database operations and **Firebase Authentication** for secure access.

Students can:
- View upcoming campus events
- RSVP for events
- Submit feedback
- Calculate ticket prices dynamically

---

## 🛠️ Technologies Used

- Blazor WebAssembly Standalone
- .NET 8
- C#
- Firebase Firestore
- Firebase Authentication
- JavaScript Interop

---

## 🗂️ System Architecture

Frontend:
- Blazor WebAssembly (Client-side)

Backend:
- Firebase Firestore (Cloud NoSQL Database)
- Firebase Authentication (Email/Password)

Database Structure:

events (collection)
   └── eventId (document)
        ├── title
        ├── description
        ├── date
        ├── venue
        ├── baseTicketPrice
        ├── rsvps (subcollection)
        └── feedback (subcollection)

---

## ⚙️ How to Run the Project

### 1️⃣ Clone the Repository
2️⃣ Open in Visual Studio

Open the .sln file

Restore NuGet packages
3️⃣ Configure Firebase

Open:

wwwroot/index.html

Replace the firebaseConfig object with your own Firebase credentials.

Make sure:

Firestore Database is enabled

Authentication (Email/Password) is enabled

4️⃣ Run the Project

Set project as Startup Project → Press Ctrl + F5

👨‍💻 Developed For

Academic Project – Mobile and Web Technologies (SEN5001)

```bash
git clone https://github.com/YOUR-USERNAME/EventUserDashboard.git
