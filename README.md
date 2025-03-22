# 🛍️ Shopify - E-Commerce Windows Forms Application

Welcome to **Shopify**, a desktop e-commerce application built using **C#**, **Windows Forms**, and **ADO.NET** for database interactions. This application allows users to browse products, manage their profiles, and interact with an e-commerce system. Administrators can manage users, products, and categories.

---

## 🚀 Features

### **User Features**
- **Register**: Create a new account.
- **Login**: Log in to the application.
- **Add to Favorites**: Add products to your favorites list.
- **Remove from Favorites**: Remove products from your favorites list.
- **Edit Profile**: Update your profile information.
- **Change Password**: Change your account password.
- **Logout**: Log out of your account.

### **Admin Features**
- **Manage Users**: Add, update, or delete users.
- **Manage Products**: Add, update, or delete products.
- **Manage Categories**: Add, update, or delete categories.

---

## 🛠️ Technologies Used

- **Programming Language**: C#
- **Framework**: .NET Framework / .NET Core
- **Database**: SQL Server
- **Database Interaction**: ADO.NET
- **UI Framework**: Windows Forms

---

## Screenshots

### Login & Register
![Home Page](./images/Home.png)
![Login Page](./images/Login.png)
![Register Page](./images/Register.png)


### User
![User Home Page](./images/UserHome.png)
![User Favourite Page](./images/UserFavourite.png)
![User Profile Page](./images/UserProfile.png)
![User Edit Profile Page](./images/UserEditProfile.png)
![User Change Password Page](./images/UserChangePassword.png)


### Admin
![Admin Home Page](./images/AdminHome.png)
![Admin Products Page](./images/AddProduct.png)
![Admin Add Product Page](./images/AddProduct.png)
![Admin Update Product Page](./images/UpdateProdcut.png)


---

## 📦 Installation

Follow these steps to install and run the project on your local machine:

### **Prerequisites**
1. **Visual Studio**: Download and install [Visual Studio](https://visualstudio.microsoft.com/).
2. **SQL Server**: Install [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and **SQL Server Management Studio (SSMS)**.
3. **.NET Framework**: Ensure you have the .NET Framework installed (comes with Visual Studio).

### **Steps**
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/AhmedHamdy3/Shopify.git
   ```
2. **Open the Project**:
   - Open the solution file (`Shopify.sln`) in Visual Studio.
3. **Set Up the Database**:
   - Run the SQL scripts provided in the `Database` folder to create the necessary tables and insert sample data.

4. **Set Up the `app.config` File**:
    1. **Create the `app.config` File**:
       - In the `Shopify.Presentation` project, right-click on the project name in the Solution Explorer.
       - Select **Add** > **New Item**.
       - Choose **Application Configuration File** and name it `app.config`.
    
    2. **Add the Connection String**:
       - Open the `app.config` file and add the following code:
         ```xml
         <?xml version="1.0" encoding="utf-8"?>
         <configuration>
           <connectionStrings>
             <add name="Shopify" 
                  connectionString="Server=your_server_name;Database=FinalProject;
                  Trusted_Connection=True; Trust Server Certificate=True"/>
           </connectionStrings>
         </configuration>
            ```
    3. **Update the Connection String**:
       - Replace the placeholders in the `connectionString` attribute with your SQL Server credentials:
         - `your_server_name`: The name of your SQL Server instance (e.g., `localhost`, `.\\SQLEXPRESS`, or a remote server address).

5. **Build and Run**:
   - Build the project in Visual Studio.
   - Run the application by pressing `F5` or clicking the **Start** button.

---


## 🐛 Reporting Issues

If you find any bugs or have suggestions for improvements, please open an issue on the [GitHub Issues](https://github.com/your-username/shopify-ecommerce/issues) page. Be sure to include:
- A clear description of the issue.
- Steps to reproduce the issue.
- Screenshots (if applicable).

---

## 🔜 Next Steps

Here are some ideas for future improvements:
- **Add a Shopping Cart**: Allow users to add products to a cart and proceed to checkout.
- **Implement Payment Integration**: Integrate with payment gateways like PayPal or Stripe.
- **Add Search Functionality**: Allow users to search for products by name or category.
- **Enhance UI/UX**: Improve the design and user experience of the application.
- **Add Reports for Admin**: Provide sales and user activity reports for administrators.

---




Enjoy using **Shopify**! 🎉



