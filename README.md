# ASP.NET Web API and Azure Function Integration

## Overview
This repository contains a sample project that demonstrates the integration between an ASP.NET Web API and an Azure Function with an HTTP trigger. The ASP.NET Web API serves as a client, communicating with the function app to execute specific tasks triggered by HTTP requests.

## Features

### ASP.NET Web API Client
- A robust ASP.NET Web API project that acts as a client to the Azure Function.
- Demonstrates making HTTP requests to the Azure Function's HTTP trigger endpoint.

### Azure Function with HTTP Trigger
- An Azure Functions project with an HTTP-triggered function.
- Handles incoming HTTP requests and executes logic based on the trigger.

### Azure App Service on Linux
- Deployment scripts and configurations for hosting the ASP.NET Web API on Azure App Service.
- App Service is configured to run on a Linux OS.

## Technologies Used
- ASP.NET Web API
- Azure Functions (HTTP Trigger)
- Azure App Service
- Linux OS for App Service

## Getting Started
1. Clone the repository: `git clone https://github.com/elkamelsallemi/Sindibad.git`
2. Explore the `sindibad.web` and `sindibad.function.app` folders for the respective projects.
3. Set up Azure resources (Azure Function and App Service) using the provided deployment scripts or manually.

## Deployment
- Configure the Azure App Service deployment for continuous deployment from this repository.

## Contributing
Feel free to contribute to the project by opening issues, submitting pull requests, or suggesting improvements. Your contributions are highly appreciated!

## License
This project is licensed under the GNU Affero General Public License v3.0.

## Acknowledgments
Special thanks to the contributors and the open-source community for making this project possible.
