[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<br />
<p align="center">
  <a href="https://github.com/ahmet-cetinkaya/ReCapProject">
    <img src="https://user-images.githubusercontent.com/53148314/110218503-2f2ef700-7ecb-11eb-9753-6f760c72511e.png" alt="ReCap Project">
  </a>
  <h2 align="center">ReCapProject</h2>
  <p align="center">
    Car Rental project with N-Layer Architecture.
    <br />
    <br />
    <a href="https://github.com/ahmet-cetinkaya/ReCapProject/issues">Report Bug</a>
    ·
    <a href="https://github.com/ahmet-cetinkaya/ReCapProject/issues">Request Feature</a>
  </p>
</p>

<details open="open">
  <summary><strong>Table of Contents</strong></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
    <a href="#usage">Usage</a>
    <ul>
        <li><a href="#specifications">Specifications</a></li>
      </ul>
    </li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>

## About The Project

### Built With

[![C-Sharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Asp-net](https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![MSSQL](https://img.shields.io/badge/MSSQL-004880?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/sql-server-2019?rtc=2)
[![Entity-Framework](https://img.shields.io/badge/Entity%20Framework-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![Autofac](https://img.shields.io/badge/Autofac-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://autofac.org/)
[![Fluent-Validation](https://img.shields.io/badge/Fluent%20Validation-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://fluentvalidation.net/)

## Usage

### Specifications

<details>
  <summary>Toggle Content</summary>

#### Cars

### Public Operations

- List all cars
  - Searching Cars By Brand, Color
  - Caching
- Get a single car
  - Caching

### Private Operations

- Ask (Create) a New Car
  - Authenticated users only (Logged In Users)
  - Field validation
- Edit a Question
  - Authenticated users only (Logged In Users)
  - Field Validation
- Delete a Question
  - Authenticated users only (Logged In Users)

#### Car Images

#### Public Operations

- List all car images
- Get a car image
  - Searching Car Image By Car
  - Caching

#### Private Operations

- Ask (Create) a New Car Image
  - Authenticated users only (Logged In Users)
- Edit a Car Image
  - Authenticated users only (Logged In Users)
- Delete a Car Image
  - Authenticated users only (Logged In Users)

#### Brands

#### Public Operations

- Get All Brands
- Get Single Brand

#### Private Operations

- Add (Create) a New Answer To Question
  - Authenticated users only (Logged In Users)
- Edit a Answer
  - Authenticated users only (Logged In Users)
- Delete a Answer
  - Authenticated users only (Logged In Users)

#### Color

#### Public Operations

- Get All Colors
- Get Single Color

#### Private Operations

- Add (Create) a Color
  - Authenticated users only (Logged In Users)
- Edit a Color
  - Authenticated users only (Logged In Users)
- Delete a Color
  - Authenticated users only (Logged In Users)

#### Customer

#### Public Operations

- Get All Customers
- Get Single Customer

#### Private Operations

- Add (Create) a Customer
  - Authenticated users only (Logged In Users)
- Edit a Customer
  - Authenticated users only (Logged In Users)
- Delete a Customer
  - Authenticated users only (Logged In Users)

#### Rental

#### Public Operations

- Get All Rentals
- Get Single Rental

#### Private Operations

- Add (Create) a Rental
  - Authenticated users only (Logged In Users)
- Edit a Rental
  - Authenticated users only (Logged In Users)
- Delete a Rental
  - Authenticated users only (Logged In Users)

#### Users

#### Public Operations

- List all Users
- Get a User
- Add (Create) a User

#### Private Operations

- Edit a User
  - Authenticated users only (Logged In Users)
- Delete a User
  - Authenticated users only (Logged In Users)

## Authentication

Requests are authenticated using the `Authorization` header and value `Bearer {{token}}`. with a valid JWT.

- Authentication Strategy : JWT
  - JWT Expiration : 10 Minutes For Testing Api
- Registration
  - User can register as a "Admin" or simply "User"
  - Password Salt
  - Password Hash
  - Token includes : "id", "email", "name" and "roles"
  <!-- - Token Are Stored In Cookie -->
- Login
  - User can login with "email" and "password"
  - Everytime a user login, new Token are sent to to client

## Models

### User

| Name        | Data Type     | Allow Nulls | Default |
| :---------- | :------------ | :---------- | :------ |
| Id          | int           | False       |         |
| Name        | nvarchar(50)  | False       |         |
| BrandId     | int           | False       |         |
| ColorId     | int           | False       |         |
| DailyPrice  | decimal(18,0) | False       |         |
| ModelYear   | smallint      | False       |         |
| Description | nvarchar(50)  | True        |         |

### Car Images

| Name      | Data Type     | Allow Nulls | Default |
| :-------- | :------------ | :---------- | :------ |
| Id        | int           | False       |         |
| CarId     | int           | False       |         |
| ImagePath | nvarchar(MAX) | False       |         |
| Date      | datetime      | False       |         |

## Brands

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | nvarchar(25) | False       |         |

## Color

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | nvarchar(25) | False       |         |

## Customer

| Name        | Data Type | Allow Nulls | Default |
| :---------- | :-------- | :---------- | :------ |
| Id          | int       | False       |         |
| UserId      | int       | False       |         |
| CompanyName | nchar(50) | True        |         |

## Rental

| Name       | Data Type | Allow Nulls | Default |
| :--------- | :-------- | :---------- | :------ |
| Id         | int       | False       |         |
| CarId      | int       | False       |         |
| CustomerId | int       | False       |         |
| RentDate   | datetime  | True        |         |
| ReturnDate | datetime  | True        |         |

## Users

| Name         | Data Type      | Allow Nulls | Default |
| :----------- | :------------- | :---------- | :------ |
| Id           | int            | False       |         |
| FirstName    | nvarchar(50)   | False       |         |
| LastName     | nvarchar(50)   | False       |         |
| Email        | nvarchar(50)   | False       |         |
| PasswordHash | varbinary(500) | False       |         |
| PasswordSalt | varbinary(500) | False       |         |
| Status       | bit            | False       |         |

## OperationClaims

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | varchar(250) | False       |         |

## UserOperationClaims

| Name             | Data Type | Allow Nulls | Default |
| :--------------- | :-------- | :---------- | :------ |
| Id               | int       | False       |         |
| UserId           | int       | False       |         |
| OperationClaimId | int       | False       |         |

## Layers

### Business

Business Layer created to process or control the incoming information according to the required conditions.

### Core

Core layer containing various particles independent of the project.

### DataAccess

Data Access Layer created to perform database CRUD operations.

### Entities

Entities Layer created for database tables.

### WebAPI

Web API Layer that opens the business layer to the internet.

</details>
<p></p>

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.

## Contact

Ahmet ÇETİNKAYA - [ahmetcetinkaya.info](https://ahmetcetinkaya.info/)

Project Link: [https://github.com/ahmet-cetinkaya/ReCapProject](https://github.com/ahmet-cetinkaya/ReCapProject)

## Acknowledgements

- engindemirog

[contributors-shield]: https://img.shields.io/github/contributors/ahmet-cetinkaya/ReCapProject.svg?style=for-the-badge
[contributors-url]: https://github.com/ahmet-cetinkaya/ReCapProject/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ahmet-cetinkaya/ReCapProject.svg?style=for-the-badge
[forks-url]: https://github.com/ahmet-cetinkaya/ReCapProject/network/members
[stars-shield]: https://img.shields.io/github/stars/ahmet-cetinkaya/ReCapProject.svg?style=for-the-badge
[stars-url]: https://github.com/ahmet-cetinkaya/ReCapProject/stargazers
[issues-shield]: https://img.shields.io/github/issues/ahmet-cetinkaya/ReCapProject.svg?style=for-the-badge
[issues-url]: https://github.com/ahmet-cetinkaya/ReCapProject/issues
[license-shield]: https://img.shields.io/github/license/ahmet-cetinkaya/ReCapProject.svg?style=for-the-badge
[license-url]: https://github.com/ahmet-cetinkaya/ReCapProject/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/ahmet-cetinkaya
