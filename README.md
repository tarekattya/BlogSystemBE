# BlogSystem (Clean Architecture + CQRS + Vertical Slicing)

## ✅ Progress Until Now

### 1. Domain Layer

-   Created **Entities**:
    -   `BlogPost`
    -   `Category`
    -   `Tag`
    -   `BlogPostTag` (many-to-many relation)
    -   `Comment`
-   Added **Enum**:
    -   `PostStatus` (Draft, Published, Archived)
-   Removed `User` & `Audit Fields` for now (will be added later with
    Identity & Auth module).

------------------------------------------------------------------------

### 2. Infrastructure Layer

-   Created **DbContext**:

    -   `BlogDbContext` with `DbSets` for all entities.

-   Implemented **Entity Configurations** (Best Practice):

    -   `BlogPostConfiguration`
    -   `CategoryConfiguration`
    -   `CommentConfiguration`
    -   `TagConfiguration`
    -   `BlogPostTagConfiguration` (M-M relation setup)

-   Applied configurations using:

    ``` csharp
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogDbContext).Assembly);
    ```

-   Registered `DbContext` in **Dependency Injection** via `Dependency`
    class:

    ``` csharp
    services.AddDbContext<BlogDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    ```

------------------------------------------------------------------------

### 3. Database (Migrations)

-   Installed necessary EF Core packages:

    -   `Microsoft.EntityFrameworkCore`
    -   `Microsoft.EntityFrameworkCore.SqlServer`
    -   `Microsoft.EntityFrameworkCore.Design`
    -   `Microsoft.EntityFrameworkCore.Tools`

-   Created initial migration:

    ``` powershell
    Add-Migration InitMigration -o Data/Migrations
    ```

-   Applied migration to generate database:

    ``` powershell
    Update-Database
    ```

-   **Database schema includes**:

    -   Categories
    -   Tags
    -   BlogPosts
    -   BlogPostTags (M-M)
    -   Comments

-   Relationships validated:

    -   1-M: Category → BlogPosts
    -   1-M: BlogPost → Comments
    -   M-M: BlogPosts ↔ Tags

------------------------------------------------------------------------

## 📂 Current Project Structure

    BlogSystem.sln
     ├── BlogSystem.Domain
     │    └── Entities, Enums
     │
     ├── BlogSystem.Infrastructure
     │    ├── Persistence
     │    │    ├── Data (BlogDbContext)
     │    │    └── Configurations (EntityTypeConfigurations)
     │    └── Migrations
     │
     └── BlogSystem.API
          ├── Program.cs
          └── Dependency.cs (Dependency Injection setup)

------------------------------------------------------------------------

## 🚀 Next Steps

-   Add **User & Identity** module.
-   Extend entities with **Audit Fields** (CreatedAt, CreatedBy,
    UpdatedAt, UpdatedBy).
-   Implement **Generic Repository** in Infrastructure.
-   Setup **CQRS Handlers** in Application Layer.
-   Add **Controllers** in API Layer.

------------------------------------------------------------------------
