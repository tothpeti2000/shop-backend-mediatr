# Shop

## How to run the project?

- Run `dotnet new tool-manifest` and `dotnet tool install SwashBuckle.AspNetCore.Cli --version 6.2.3` in the **root** folder
- Run `dotnet run` in the **API** folder to start the backend
- Run `docker-compose up` in the **root** folder to start the SMTP mail server (In case you encounter the _error during connect: this error may indicate that the docker daemon is not running_ error, start Docker Desktop to fix the issue, then run the command again)
- Go to http://localhost:1080 to open your mailbox and see the incoming messages
