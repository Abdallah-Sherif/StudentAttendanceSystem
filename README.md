# Student Attendance Management System

## Overview
The **Student Attendance Management System** is a web-based application designed to automate the process of tracking and managing student attendance. The system allows instructors to record attendance, administrators to manage users and courses, and students to view and request corrections to their attendance.

---
##Table Of Content
- [Features](#features)
- [Use Case Diagram](#use-case-diagram)
- [Sequence Diagram](#sequence-diagram)
- [Functional Requirements](#functional-requirements)
- [Non-Functional Requirements](#non-functional-requirements)
- [Access Roles](#access-roles)
- [Contributors](#contributors)
---
## Features

### Instructor
- Record student attendance
- Generate attendance reports
- Send notification emails to frequently absent students
- Manage students with high absence rates

### Administrator
- Add/Remove students from courses
- Modify student data
- Assign/Remove instructors from courses
- View attendance reports

### Student
- View personal attendance records
- Submit attendance correction requests

---
## Use Case Diagram

![Use Case Diagram](https://github.com/user-attachments/assets/bd931536-2f51-4c1d-baf2-68458a1f9989)


---

## Sequence Diagram

![Sequence Diagram](https://github.com/user-attachments/assets/d103100f-a59a-4e49-9385-067ccb5f2d4a)


---

## Functional Requirements

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

## Non-Functional Requirements
- **Usability**: Intuitive UI
- **Performance**: < 2s per operation
- **Reliability**: 99.9% uptime
- **Security**: Role-based access, encryption
- **Scalability**: Supports up to 10,000 students
- **Data Integrity**: No access to unauthorized records
- **User Accountability**: Only instructors manage attendance

---

## Access Roles
| Role          | Permissions                                                                 |
|---------------|------------------------------------------------------------------------------|
| Student       | View attendance, request corrections                                        |
| Instructor    | Record/view attendance, notify, generate reports                            |
| Administrator | Full control: manage users, courses, assign instructors, view reports       |

---
## Contributors
|                   Name                    |    Github Link   |
| :---------------------------------------: | :--------: |
|      Zaid Hany Mohamed Salah El Deen      | https://github.com/ElAlbany |
| Tasneem Mohamed Ahmed Mohamed | https://github.com/Tasneem357Mohamed |
|      Basmala Tarek kamal Khalil Elbagoury     | https://github.com/Bsmalatarek |
|          Mariam Ibrahim Hamdan Hamed        |  |
|           Abdallah Sherif Samir Mahmoud          | https://github.com/Abdallah-Sherif |
|       Marwan Hossam Ahmad Abdullah        | https://github.com/marwanhossam00 |
| Mahmoud Mohamed Hussien Tawfek            |  https://github.com/mahmouddmohammed |
