# 🎓 Student Billing Process API Stack

Welcome to the Student Billing Process API Stack! This API stack facilitates efficient billing operations for students at our prestigious educational institution. It allows students to view their bills, make payments, and access payment history securely and conveniently.

## Table of Contents 📚
1. [Technical Requirements](#technical-requirements)
2. [Project Setup](#project-setup)
3. [API Documentation](#api-documentation)
4. [Demonstration](#demonstration)
5. [Deployment](#deployment)

## Technical Requirements 🛠️

The API stack is built using ASP.NET Core Web API, following RESTful principles. It ensures security, scalability, and user-friendly interactions for student billing operations.

## Project Setup ⚙️

To set up the project, follow these steps:

1. Install Visual Studio or Visual Studio Code with the ASP.NET Core workload.
2. Clone this repository to your local machine.
3. Open the solution file (`StudentBillingAPI.sln`) in Visual Studio or the project folder in Visual Studio Code.
4. Set up the database by running the necessary database scripts provided separately.
5. Update the database connection string in the `appsettings.json` file to point to your database.
6. Build the solution to resolve dependencies.
7. Run the application by pressing F5 or using `dotnet run` command in the terminal.

## API Documentation 📝

The API documentation is generated using Swagger/OpenAPI. After running the application, access the Swagger UI through the following URL: `https://localhost:<port>/swagger/index.html`.

This documentation provides detailed information about each API endpoint, request parameters, responses, and necessary authorization headers.

## Demonstration 🚀

### Retrieve Student Bills

Endpoint: `GET /api/student/{studentId}/bills`

Sample Request:
GET https://localhost:<port>/api/student/123/bills


Sample Response (HTTP 200 OK):
```json
[
    {
        "billId": 1,
        "amount": 500,
        "dueDate": "2023-08-15"
    },
    {
        "billId": 2,
        "amount": 350,
        "dueDate": "2023-09-15"
    }
]
Make Payment
Endpoint: POST /api/bill/{billId}/payment

Sample Request:
POST https://localhost:<port>/api/bill/1/payment
Content-Type: application/json

{
    "paymentAmount": 300
}
Sample Response (HTTP 200 OK):
{
    "paymentId": 1,
    "paymentAmount": 300,
    "paymentDate": "2023-07-28"
}
Retrieve Payment History
Endpoint: GET /api/student/{studentId}/payment-history

Sample Request:
GET https://localhost:<port>/api/student/123/payment-history

Sample Response (HTTP 200 OK):
[
    {
        "paymentId": 1,
        "paymentAmount": 300,
        "paymentDate": "2023-07-28"
    },
    {
        "paymentId": 2,
        "paymentAmount": 150,
        "paymentDate": "2023-08-10"
    }
]
Deployment 🚀
To deploy the API stack to a production server, follow these steps:

Publish the API project to generate the deployment-ready files.
Configure the production database connection string in the appsettings.json file.
Set up the necessary security measures, such as HTTPS and rate limiting, on the production server.
Deploy the published files to the production server.
