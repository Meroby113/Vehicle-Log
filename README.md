# Meroby113 - Vehicle System
This application is a desktop application that keeps track of users, each user's vehicle, fuel purchases for their vehicles, and the user's budget.
# Aim of The Project
To learn how to use data-first approach in entitiy framework by using fallowing languages, frameworks and tools.
# Languages, Frameworks and Technological Tools Used for the Project 
* Language:
  * C#
* Framework:
  * Entity Framework 
  * LINQ 
  * Generic Repository 
* UI Framework:
  * Windows Forms App
* Database:
  * MSSQL 
* Technological Tools:
  * Visual Studio 2022
  * SQL Server Management Studio 20

# Main Page of Application
![image](https://github.com/user-attachments/assets/c7b088d5-2dac-49de-96ce-533f9ee10c8d)

# Add Customer
By clicking the "Add Customer" button, you can add a new customer<br /><br />
![image](https://github.com/user-attachments/assets/26965b56-b2a7-49dd-8849-7bee45ae3862)
# List Customers
The List Customers button will open this page. On this page all recorded customers are listed. <br /><br />
![image](https://github.com/user-attachments/assets/13e5a391-7a6c-44ab-9d92-14fc15f5d9ac)
<code style="color:red">Search For Customer:</code> If you enter customer name or surname, all related customers will be listed in DataGridView.<br />
<code style="color : red">Approval Status:</code> When the customer added for the first time, Approvel status is set to "pending". <br /><br />
Note that, when approval status is "Pending" or "Denied"  you cannot add a vehicle, see vehicle list or view the budget.<br /> 
If you want to perform these operations, you first need to change theapprovel status "Approved" by clicking the approval status button.<br />

# Add Vehicle
In this section, you can add your customer's vehicles by entering Vehicle Type, Plate Number and Fuel Type.<br /><br />
![image](https://github.com/user-attachments/assets/0881b544-0934-4487-915f-dc2186441931)
# Vehicle List
When you click "Show Vehicle List" all vehicles that the customer has will be listed.<br /><br />
![image](https://github.com/user-attachments/assets/9084da78-a03e-4db9-ad23-f818d1201f4b)<br /><br />
<code style="color : red">Add Fuel:</code>You can add fuel to each of your vehicles.<br /><br />
![image](https://github.com/user-attachments/assets/86c38947-38c1-4c61-915a-e5fe2c2dcc85)<br /><br />
Note: If you do not have a balance you cannot add fuel to your vehicle, firstly customer budget needs to be added. Otherwise you will get this error message.<br />
![image](https://github.com/user-attachments/assets/1680dfd5-12c6-49b6-b2c5-a6c7acdff83b)
# Show Budget
When you add the customer for the first time ustomer's budget will be empty, so before adding fuel you need to add your customer budget.<br />
For each fuel purchase your money will decrease.<br /><br />
![image](https://github.com/user-attachments/assets/1f36845b-b7fd-4851-b0d1-b30e11ecb627)<br /><br />
<code style="color : red">Fuel History:</code> You can see each vehicle's fuel purchase history<br /><br />
![image](https://github.com/user-attachments/assets/600f281b-f365-4291-b00f-0eec957cd64c)<br /><br />
<code style="color : red">Delete Vehicle:</code> You can delete vehicle by clicking that button, but be careful all related fual purchase historly will be deleted after deleting the vehicle.<br />
# Delete Customer
You can delete a customer and all related data by clicking the "Delete Customer" button.




