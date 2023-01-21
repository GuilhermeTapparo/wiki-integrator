FROM mcr.microsoft.com/dotnet/core/sdk:2.2

# Copy files to app directory
COPY . /app

# Set working directory
WORKDIR /app/WikiIntegrator

# Restore NuGet packages
RUN ["dotnet", "restore"]

# Build the app
RUN ["dotnet", "build"]

# Run the app
ENTRYPOINT ["dotnet", "run"]
