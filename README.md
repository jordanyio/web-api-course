# .NET 8 WebAPI Backend Server Tutorial Series

Welcome to the repository for my **YouTube tutorial series** on building backend servers with **.NET 8 WebAPI**! This series is designed to guide you through the process of building robust, scalable backend services, with each lesson progressively adding new layers of complexity and quality. The project uses **Docker** for local development, integrates with **PostgreSQL** via **Entity Framework Core (EF Core)**, and follows an **NLayer architecture**—ideal for small servers supporting SPA apps or microservices. Please note, that this was built to be used as the server for my youtube tutorial series on building a UI with React js, and Vue js. Where both of those projects depend on this server.

## Intended Use

This tutorial series is designed with beginner to intermediate learners in mind. It's perfect for those who know the basics, like loops and conditionals, and want to dive into real object-oriented programming (OOP). Whether you're a bootcamp graduate, a college student, or a self-taught developer looking to expand your skill set, this series will help you gain practical experience with modern backend development techniques.

In addition to being an educational resource, this repository is a valuable reference tool. You can return to it while working on your own projects, mirroring the style and solutions presented here. The series is also ideal for those seeking focused tutorials on specific topics, such as getting started with Docker, which is covered in one of the lessons.

This makes it a versatile resource for both learning and reference, catering to a wide range of developers looking to enhance their backend development skills.

## Repository Structure

This repository is organized into branches, with each branch corresponding to a specific video in the series. The branches are named according to the lesson number (e.g., `lesson-01`, `lesson-02`, etc.).

Each branch contains the complete code for that lesson, including any placeholder code that we intentionally use to keep the series moving forward. Later branches will revisit and refactor this code as we build further.

## Key Concepts

### Docker Integration
We use Docker to containerize our application, making it easy to set up a consistent local development environment. This includes integration with Docker images like PostgreSQL, which we use to manage our data storage with EF Core.

- [Docker Documentation](https://docs.docker.com/)
- [PostgreSQL Docker Image](https://hub.docker.com/_/postgres)
- [EF Core Documentation](https://docs.microsoft.com/en-us/ef/core/)

### NLayer Architecture
The project is structured using an NLayer architecture, which separates concerns into distinct layers, such as:
- **Presentation Layer:** Where the WebAPI lives.
- **Application Layer:** Handles business logic.
- **Domain Layer:** Contains domain entities and business rules.
- **Infrastructure Layer:** Manages data access, including EF Core integration with PostgreSQL.

This architecture is particularly suited for small servers that need to support Single Page Applications (SPAs) or microservices.

- [NLayer Architecture Explained](https://martinfowler.com/bliki/PresentationDomainDataLayering.html)
- [Microsoft's Guide to Layered Architectures](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)

## How to Use This Repository

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name
