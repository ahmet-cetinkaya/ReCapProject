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

# About The Project

## Built With

[![C-Sharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Asp-net](https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![MSSQL](https://img.shields.io/badge/MSSQL-004880?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/sql-server-2019?rtc=2)
[![Entity-Framework](https://img.shields.io/badge/Entity%20Framework-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![Autofac](https://img.shields.io/badge/Autofac-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://autofac.org/)
[![Fluent-Validation](https://img.shields.io/badge/Fluent%20Validation-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://fluentvalidation.net/)

## Specifications

<details>
  <summary>Toggle Content</summary>

### Cars

#### Public Operations

- Get all cars
  - Searching Cars By Brand, Color
  - Caching
- Get a single car
  - Caching

#### Private Operations

- Add a New Car
  - Authorized users only
  - Field validation
- Edit a Car
  - Authorized users only
  - Field Validation
- Delete a Car
  - Authorized users only

### Car Images

#### Public Operations

- Get a car image
  - Caching
- Get all
  - Searching Car Image By Car
  - Caching

#### Private Operations

- Add (Upload) a New Car Image
  - Authorized users only
  - Save on Disk
- Edit a Car Image
  - Authorized users only
  - Edit on Disk
- Delete a Car Image
  - Authorized users only
  - Delete on Disk

### Brands

#### Public Operations

- Get all brands
- Get a brand

#### Private Operations

- Add a Brand
  - Authorized users only
- Edit a Brand
  - Authorized users only
- Delete a Brand
  - Authorized users only

### Color

#### Public Operations

- Get All Colors
- Get Single Color

#### Private Operations

- Add a Color
  - Authorized users only
- Edit a Color
  - Authorized users only
- Delete a Color
  - Authorized users only

### Customer

#### Public Operations

- Add a Customer

#### Private Operations

- Get All Customers
  - Authorized users only
- Get Single Customer
  - Authorized users only
- Edit a Customer
  - Authorized users only
- Delete a Customer
  - Authorized users only

### Rental

#### Public Operations

- Get All Rentals
  - Searching Rental By Car
  - Logged users only
- Get Single Rental
  - Logged users only
- Add a Rental
  - Logged users only
- Check Car is Rentable
- Check Findeks Score Sufficiency

#### Private Operations

- Edit a Rental
  - Authorized users only
- Delete a Rental
  - Authorized users only

### Users

#### Public Operations

- Get User Detail By Mail
- Add a User
- Update User Details
  - Logged users only

#### Private Operations

- Get a User
  - Searching user by mail
  - Authorized users only
- Get all Users
  - Authorized users only
- Edit a User
  - Authorized users only
- Delete a User
  - Authorized users only

### Authentication

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

#### Public Operations

- Login
  - Logged users only
  - Create Access Token
- Register new user
  - Create Access Token
- Check User Exists
- Check user is authenticated
  - Logged users only

#### Private Operations

- Encryption
- Hashing
- JWT

### Operation Claim

#### Public Operations

- Get a Operation Claim
  - Searching Operation Claim by name
- Get all Operation Claim

#### Private Operations

- Add a Operation Claim
  - Authorized users only
- Edit a Operation Claim
  - Authorized users only
- Delete a Operation Claim
  - Authorized users only

### User Operation Claim

#### Public Operations

- Add 'User' Claim

#### Private Operations

- Get a User Operation Claim
  - Authorized users only
- Get all User Operation Claim
  - Authorized users only
- Add a User Operation Claim
  - Authorized users only
- Edit a User Operation Claim
  - Authorized users only
- Delete a User Operation Claim
  - Authorized users only

### Credit Card (Test)

#### Public Operations

- Get a Credit Card
  - Logged users only
- Get all Users
  - Logged users only
  - Searching Credit Card by Customer
- Add a Credit Card
  - Logged users only
- Delete User Details
  - Logged users only

### Payment (Test)

#### Public Operations

- Payment (Fake)

### Findeks (Test)

#### Public Operations

- Searching Findeks by Customer
  - Logged users only
- Add a Findeks
  - Logged users only
- Update a Findeks
  - Logged users only
- Calculate Findeks Score (Fake)

#### Private Operations

- Get a Findeks
  - Authorized users only
- Get all
  - Authorized users only
- Update findeks
  - Authorized users only
- Delete findeks
  - Authorized users only

</details><p></p>

## Layers

<details>
  <summary>Toggle Content</summary>

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

</details><p></p>

## Models

<details>
  <summary>Toggle Content</summary>

### Brands

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | nvarchar(25) | False       |         |

### Car Images

| Name      | Data Type     | Allow Nulls | Default |
| :-------- | :------------ | :---------- | :------ |
| Id        | int           | False       |         |
| CarId     | int           | False       |         |
| ImagePath | nvarchar(MAX) | False       |         |
| Date      | datetime      | False       |         |

### Car

| Name            | Data Type     | Allow Nulls | Default |
| :-------------- | :------------ | :---------- | :------ |
| Id              | int           | False       |         |
| Name            | nvarchar(50)  | False       |         |
| BrandId         | int           | False       |         |
| ColorId         | int           | False       |         |
| DailyPrice      | decimal(18,0) | False       |         |
| ModelYear       | smallint      | False       |         |
| Description     | nvarchar(50)  | True        |         |
| MinFindeksScore | smallint      | False       | ((0))   |

### Color

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | nvarchar(25) | False       |         |

### Credit Card (Test)

| Name        | Data Type     | Allow Nulls | Default |
| :---------- | :------------ | :---------- | :------ |
| Id          | int           | False       |         |
| CustomerId  | int           | False       |         |
| NameSurname | nvarchar(100) | False       |         |
| CardNumber  | nvarchar(25)  | False       |         |
| ExpMonth    | tinyint       | False       |         |
| ExpYear     | tinyint       | False       |         |
| Cvc         | nvarchar(3)   | False       |         |
| CardType    | nvarchar(20)  | False       |         |

### Customer

| Name        | Data Type    | Allow Nulls | Default |
| :---------- | :----------- | :---------- | :------ |
| Id          | int          | False       |         |
| UserId      | int          | False       |         |
| CompanyName | nvarchar(50) | True        |         |

### Findeks (Test)

| Name             | Data Type    | Allow Nulls | Default |
| :--------------- | :----------- | :---------- | :------ |
| Id               | int          | False       |         |
| CustomerId       | int          | False       |         |
| NationalIdentity | nvarchar(50) | False       |         |
| Score            | smallint     | False       | ((0))   |

### OperationClaims

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | varchar(250) | False       |         |

### Rental

| Name          | Data Type | Allow Nulls | Default |
| :------------ | :-------- | :---------- | :------ |
| Id            | int       | False       |         |
| CarId         | int       | False       |         |
| CustomerId    | int       | False       |         |
| RentStartDate | datetime  | False       |         |
| RentEndDate   | datetime  | False       |         |
| ReturnDate    | datetime  | True        |         |

### UserOperationClaims

| Name             | Data Type | Allow Nulls | Default |
| :--------------- | :-------- | :---------- | :------ |
| Id               | int       | False       |         |
| UserId           | int       | False       |         |
| OperationClaimId | int       | False       |         |

### Users

| Name         | Data Type      | Allow Nulls | Default |
| :----------- | :------------- | :---------- | :------ |
| Id           | int            | False       |         |
| FirstName    | nvarchar(50)   | False       |         |
| LastName     | nvarchar(50)   | False       |         |
| Email        | nvarchar(50)   | False       |         |
| PasswordHash | varbinary(500) | False       |         |
| PasswordSalt | varbinary(500) | False       |         |
| Status       | bit            | False       |         |

</details><p></p>

# Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

# License

Distributed under the MIT License. See `LICENSE` for more information.

# Contact

Ahmet ÇETİNKAYA - [ahmetcetinkaya.info](https://ahmetcetinkaya.info/)

Project Link: [https://github.com/ahmet-cetinkaya/ReCapProject](https://github.com/ahmet-cetinkaya/ReCapProject)

# Acknowledgements

- [engindemirog](https://www.linkedin.com/in/engindemirog/)

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
[linkedin-shield]: https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white
[linkedin-url]: https://linkedin.com/in/ahmet-cetinkaya
