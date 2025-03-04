PHUMLA KAMNANDI HOTELS BOOKING SYSTEM
OVERVIEW
This system manages guest bookings for Phumla Kamnandi Hotels, providing a comprehensive solution for hotel receptionists to handle reservations, modifications, and booking inquiries. The system is developed in C#.NET with a relational database backend.
CORE FEATURES

Telephone Booking Management:

Create new reservations
Verify room availability
Process guest information
Handle deposit payments
Generate booking confirmations


Booking Administration:

Modify existing bookings
Cancel reservations
View booking details and status


Reporting System:

Dynamic occupancy level reports with date range selection
Custom business intelligence reports



TECHNICAL STACK

Frontend: C#.NET Windows Forms
Backend: SQL Server Database
Architecture: Object-Oriented Design

SYSTEM REQUIREMENTS

Microsoft .NET Framework (version TBD)
SQL Server (version TBD)
Windows Operating System

INSTALLATION

Clone the repository
Restore the database backup
Update the connection string in the application config
Build and run the solution

DATABASE SCHEMA
The system uses a normalized relational database (3NF) with tables for:

Guests
Bookings
Rooms
Payments
Hotel Information

KEY USE CASES

Make a Telephone Booking:

Receptionist enters reservation details
System checks room availability
System calculates pricing
Guest details are entered/verified
Deposit payment is processed
Confirmation is generated


Change a Guest Booking:

Modify dates, room type, or guest details
System automatically updates occupancy records


Cancel a Guest Booking:

Process cancellation
Update room availability
Handle deposit refund requirements


Booking Enquiry:

Search by booking reference
View booking status (confirmed/unconfirmed)
Check deposit payment status



TESTING
The system includes comprehensive test cases covering:

Booking workflows
Data validation
Business rules enforcement
Edge cases and error handling

SECURITY FEATURES

Input validation
Data integrity checks
Credit card information security
Audit logging

PROJECT STRUCTURE
src/
|-- UI/             (User interface forms)
|-- Business/       (Business logic and controllers)
|-- DataAccess/     (Database interaction layer)
|-- Models/         (Entity classes)
|-- Utils/          (Helper functions)
|-- Tests/          (Test cases)
CONTRIBUTORS

Student Group (Department of Information Systems)
Systems Design & Implementation (INF2011S)

DOCUMENTATION
Additional documentation available in project deliverables:

Systems Specification Document
Interface Flow Diagrams
Database Design Documentation
Test Case Documentation

DEVELOPMENT GUIDELINES

Follow C# coding standards
Implement proper error handling
Document all major functions
Include unit tests for new features

PROJECT TIMELINE

Development Period: Current - October 4, 2024
Final Submission: October 4, 2024, 12:00 noon

NOTE
This system is developed as an academic project for the Department of Information Systems' Systems Design & Implementation course (INF2011S).
