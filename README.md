# Bloggerium

### Run the following commands from within  **Bloggerium.Dal** directory.

- dotnet --version  **2.1.300** 
- dotnet ef --version  **2.1.0-rtm-30799**

Commands used to add new migration to **netCore2.0**

    dotnet ef migrations add InitialCreate -v -s ../Bloggerium.Web2.0/Bloggerium.Web2.0.csproj


Commands used to add new migration to **netCore2.1**

    dotnet ef migrations add InitialCreate -v -s ../Bloggerium.Web2.1/Bloggerium.Web2.1.csproj
