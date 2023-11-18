# User Management Project

This project involves a user management system developed using the Onion Architecture. Onion Architecture is a design pattern that breaks the project into layers, reducing dependencies and creating a more testable structure.

## Project Structure

The project consists of the following basic layers:

1. **WebUI**: The layer containing the operations related to the user interface.
2. **Application**: Business logic and application services.
3. **Domain**: Business domain-related models and business logic rules.
4. **Infrastructure**: Details about the infrastructure such as database connections, and external service calls.

## Technologies

- **ASP.NET Core**: Used for web application development.
- **Entity Framework Core**: Used for database operations.
- **Onion Architecture**: Used to divide the project into layers and reduce dependencies.

## Requirements

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- A database server (e.g. SQL Server, PostgreSQL)

## Installation

1. Clone the repo: `https://github.com/iamyasinkaya/User-Management-Application.git`
2. Go to the project directory: `cd user-management-project`
3. To start the application, type the following command in the terminal or command prompt: `dotnet run`

## Usage

- After the application starts, you can access the user management interface by going to `http://localhost:5000` in the browser.

## Contribution

1. Fork this project.
2. Create a new branch: `git checkout -b new-feature`
3. Commit your changes: `git commit -am 'Add new feature'`
4. Push your branch: `git push origin new-feature`
5. Create a pull request.

## License

This project is licensed under [MIT license](LICENSE).

---

