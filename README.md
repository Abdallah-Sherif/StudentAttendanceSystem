# Student Attendance Management System

## 📚 Overview
The **Student Attendance Management System** is a web-based application designed to automate the process of tracking and managing student attendance. The system allows instructors to record attendance, administrators to manage users and courses, and students to view and request corrections to their attendance.

---

## 👥 Team Information
- **Team ID**: 2
- **Course**: Software Engineering
- **TA**: Akram Tarek

**Team Members**:
- مد حسين توفيق محمود
- محمد تسنيم محمد احمد
- بسملة طارق كمال الباجوري
- مروان حسام احمد عبدالل
- عبدالل شريف سمير محمود
- مريم ابراهيم حمدان حامد
- زيد هاني محمد صلاح الدين

---

## 🛠️ Features

### 👨‍🏫 Instructor
- Record student attendance
- Generate attendance reports
- Send notification emails to frequently absent students
- Manage students with high absence rates

### 🧑‍💼 Administrator
- Add/Remove students from courses
- Modify student data
- Assign/Remove instructors from courses
- View attendance reports

### 👩‍🎓 Student
- View personal attendance records
- Submit attendance correction requests

---

## 📋 Use Case Diagram
![Use Case Diagram](./Screenshot%202025-05-31%20at%2010.49.24%20PM.png)

---

## 🔄 Sequence Diagram
![Sequence Diagram](./Screenshot%202025-05-31%20at%2010.49.34%20PM.png)

---

## 📌 Functional Requirements (Summary)

### Instructor
- **Record Attendance**: Mark students present/absent.
- **Send Notification**: Alert students with high absence rates.
- **Manage Students in Class**: Flag students at risk due to absence.
- **Generate Attendance Report**: Summary for analysis.

### Administrator
- **Manage Users**: Add/remove users, modify data.
- **Course Management**: Assign or remove instructors/students.

### Student
- **View Own Attendance**: Access attendance logs.
- **Request Correction**: Submit errors for review.

---

## ⚙️ Non-Functional Requirements
- **Usability**: Intuitive UI
- **Performance**: < 2s per operation
- **Reliability**: 99.9% uptime
- **Security**: Role-based access, encryption
- **Scalability**: Supports up to 10,000 students
- **Data Integrity**: No access to unauthorized records
- **User Accountability**: Only instructors manage attendance

---

## 💻 Technologies Used
- Frontend: (To be filled by devs, e.g., React.js)
- Backend: (e.g., Node.js, Django)
- Database: (e.g., MySQL, PostgreSQL)
- Email Integration: SMTP / API

---

## 🔐 Access Roles
| Role          | Permissions                                                                 |
|---------------|------------------------------------------------------------------------------|
| Student       | View attendance, request corrections                                        |
| Instructor    | Record/view attendance, notify, generate reports                            |
| Administrator | Full control: manage users, courses, assign instructors, view reports       |

---

## 🚀 Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/student-attendance-system.git
   ```
2. Setup database & environment:
   ```bash
   npm install / pip install -r requirements.txt
   ```
3. Run the server:
   ```bash
   npm start / python manage.py runserver
   ```
4. Access the platform at `localhost:3000` or `localhost:8000`.

---

## 📄 License
This project is academic and developed for educational purposes.
