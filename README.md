# Bookify

## Overview

Bookify is a web application built with .NET Core MVC, designed for book enthusiasts to browse, manage, and engage with a collection of books. Whether you're discovering new reads, organizing your library, or connecting with other readers, Bookify provides a robust and user-friendly platform to enhance your reading experience.

## Sequence Diagram 
<img width="1033" height="366" alt="image" src="https://github.com/user-attachments/assets/dc05c41d-26d9-4fbc-a578-1bd60702b00b" />


## Features

- **Browse and Search**: Explore books by title, author, or genre.
- **User Authentication**: Secure login and registration system using ASP.NET Core Identity.
- **Book Management**: Add, update, or delete books in the library (for admin users).
- **Interactive Features**: Rate, review, or save books to your reading list.
- **Responsive Design**: Built with Bootstrap for seamless access on desktop and mobile devices.

## Prerequisites

To run Bookify locally, ensure you have the following installed:
- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later, depending on the project)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or another compatible database
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional, for development)

## Installation

Follow these steps to set up and run Bookify locally:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/mohamedshehatadev17/Bookify.git
   cd Bookify
   ```

2. **Restore Dependencies**:
   Restore the NuGet packages required for the project:
   ```bash
   dotnet restore
   ```

3. **Set Up the Database**:
   - Update the `appsettings.json` file with your database connection string:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=BookifyDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       }
     }
     ```
   - Replace `your_server` with your SQL Server instance name.
   - Apply database migrations to create the database schema:
     ```bash
     dotnet ef database update
     ```

4. **Run the Application**:
   - Build and run the project:
     ```bash
     dotnet build
     dotnet run
     ```
   - Open `https://localhost:5001` (or the configured port) in your browser to view the app.

## Usage

- **Sign Up/Login**: Register a new account or log in using ASP.NET Core Identity.
- **Browse Books**: Use the search functionality or navigate through categories to find books.
- **Manage Library**: Admin users can add, edit, or delete book listings via the admin panel.
- **Engage**: Leave reviews, rate books, or add them to your personal reading list.

## Contributing

Contributions are welcome! To contribute to Bookify:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add your feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a Pull Request.

Please read `CONTRIBUTING.md` (if available) for detailed guidelines.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact

For questions or feedback, reach out to the project maintainer at [mohamedshehatadev17](https://github.com/mohamedshehatadev17).



## Overview

Bookify is a web application built with .NET Core MVC, designed for book enthusiasts to browse, manage, and engage with a collection of books. Whether you're discovering new reads, organizing your library, or connecting with other readers, Bookify provides a robust and user-friendly platform to enhance your reading experience.

## Features

- **Browse and Search**: Explore books by title, author, or genre.
- **User Authentication**: Secure login and registration system using ASP.NET Core Identity.
- **Book Management**: Add, update, or delete books in the library (for admin users).
- **Interactive Features**: Rate, review, or save books to your reading list.
- **Responsive Design**: Built with Bootstrap for seamless access on desktop and mobile devices.

## Prerequisites

To run Bookify locally, ensure you have the following installed:
- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later, depending on the project)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or another compatible database
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional, for development)

## Installation

Follow these steps to set up and run Bookify locally:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/mohamedshehatadev17/Bookify.git
   cd Bookify
   ```

2. **Restore Dependencies**:
   Restore the NuGet packages required for the project:
   ```bash
   dotnet restore
   ```

3. **Set Up the Database**:
   - Update the `appsettings.json` file with your database connection string:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=BookifyDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       }
     }
     ```
   - Replace `your_server` with your SQL Server instance name.
   - Apply database migrations to create the database schema:
     ```bash
     dotnet ef database update
     ```

4. **Run the Application**:
   - Build and run the project:
     ```bash
     dotnet build
     dotnet run
     ```
   - Open `https://localhost:5001` (or the configured port) in your browser to view the app.

## Usage

- **Sign Up/Login**: Register a new account or log in using ASP.NET Core Identity.
- **Browse Books**: Use the search functionality or navigate through categories to find books.
- **Manage Library**: Admin users can add, edit, or delete book listings via the admin panel.
- **Engage**: Leave reviews, rate books, or add them to your personal reading list.

## Contributing

Contributions are welcome! To contribute to Bookify:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add your feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a Pull Request.

Please read `CONTRIBUTING.md` (if available) for detailed guidelines.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact

For questions or feedback, reach out to the project maintainer at [mohamedshehatadev17](https://github.com/mohamedshehatadev17).
