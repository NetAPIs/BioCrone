# BioCrone

BioCrone API is a CRUD (Create, Read, Update, Delete) web service built using ASP.NET Core 7 and MongoDB. <br>
It provides endpoints for managing biological data through a RESTful API. <br>

# Features

Create, read, update, and delete operations: The API supports basic CRUD operations for managing biological data entities, such as genes, proteins, and sequences.
MongoDB integration: BioCrone API utilizes MongoDB, a popular NoSQL database, for storing and retrieving data efficiently.
RESTful API: The API adheres to the principles of Representational State Transfer (REST), allowing for easy integration and communication with client applications.
Authentication and authorization: The API includes authentication and authorization mechanisms to ensure secure access to the endpoints.

# Prerequisites

Before installing and running BioCrone API, make sure you have the following prerequisites:

.NET SDK 7.0 <br>
MongoDB server running locally or remotely <br>

# Usage
BioCrone API exposes the following endpoints for managing biological data:

GET /api/genes: Retrieves all genes. <br>
GET /api/genes/{id}: Retrieves a specific gene by ID. <br>
POST /api/genes: Creates a new gene. <br>
PUT /api/genes/{id}: Updates a specific gene by ID. <br>
DELETE /api/genes/{id}: Deletes a specific gene by ID. <br>
You can use tools like Postman or cURL to interact with the API endpoints. <br>

For more detailed information on the API usage and available endpoints, refer to the project's documentation. <br>

# Contributing

Contributions to BioCrone API are welcome! If you'd like to contribute to the project, please follow these steps:

Fork the repository on GitHub. <br>
Create a new branch from the master branch for your contribution. <br>
Make your changes and commit them with descriptive messages. <br>
Push your changes to your forked repository. <br>
Submit a pull request to the original repository, explaining the purpose and details of your contribution. <br>
Please review the project's Contributing Guidelines for more information. <br>
