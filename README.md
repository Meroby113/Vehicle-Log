# Meroby113 - Vehicle System
This application is simply a desktop application that keeps track of users, each user's vehicle, fuel purchases for there vehicles, and the user's budget.
# Aim of The Project
To learn how to use data first approach in entitiy framework by using belove languages, frameworks and tools.
# Languages, Frameworks and Technological Tools Used For The Project 
* Language:
  * C#
* Framework:
  * Entitiy Framework 
  * Linq 
  * Generic Repository 
* UI Framework:
  * Windows Forms App
* Database:
  * MSSQL 
* Technological Tools:
  * Visual Studio 2022
  * SQL Server Management Studio 20

# Main Page of Application
![image](https://github.com/user-attachments/assets/6d6dfd5a-6ec9-4d9b-ae98-e5c08685bfc7)
# Add Customer
By clicking the "Add Customer" button you can add new customer<br />
![image](https://github.com/user-attachments/assets/26965b56-b2a7-49dd-8849-7bee45ae3862)
# List Customers
![image](https://github.com/user-attachments/assets/13e5a391-7a6c-44ab-9d92-14fc15f5d9ac)
List Customers button will open this page. In this page all recorded customers are listed. <br />
Search For Customer: If you enter customer name or surname, all related customers will be listed in datagridview.<br />
Approval Status: When the customer added for the first time, Approvel status is set as "pending". <br />
Note that, when approval status is "Pending" or "Denied"  you cannot add vehicle, cannot see vehicle list or budget.<br /> 
If you want to do that operations firstly you need to make approvel status "Approved" by cliking the approval status button.<br />
# Add Vehicle
In this section you can add your customer vehicles by entering Vehicle Type, Plate Number and Fuel Type.<br />
![image](https://github.com/user-attachments/assets/0881b544-0934-4487-915f-dc2186441931)
# Vehicle List
When you click "Show Vehicle List" all vehicles that customer has will be lised.<br />
![image](https://github.com/user-attachments/assets/9084da78-a03e-4db9-ad23-f818d1201f4b)<br />
Add Fuel: You can add fuel to each of your vehicle.<br />
Note: If you do not have balance you cannot add fuel to your vehicle, firstly customer budget need to be added. Otherwise you will get this error message<br />
![image](https://github.com/user-attachments/assets/1680dfd5-12c6-49b6-b2c5-a6c7acdff83b)
![image](https://github.com/user-attachments/assets/86c38947-38c1-4c61-915a-e5fe2c2dcc85)


![image](https://github.com/user-attachments/assets/2526bf6f-cb32-4604-bead-7f4819dfdd94)
# Show Budget
When you add the customer for the first time budget will be empty, so before adding fuel you need to add your customer budget.<br />
For each fuel purchase your money will be decreased.<br />
![image](https://github.com/user-attachments/assets/1f36845b-b7fd-4851-b0d1-b30e11ecb627)
![image](https://github.com/user-attachments/assets/b82a59c0-c71e-4447-810b-daa41d2cc983)
![image](https://github.com/user-attachments/assets/84653605-1c88-43dc-9a00-6b26535dc154)


Fuel History: You can see each vehicles fuel purchase history<br />
![image](https://github.com/user-attachments/assets/600f281b-f365-4291-b00f-0eec957cd64c)<br />
Delete Vehicle: You can delete vehicle by clicking that button, but be careful all related fual purchase historly will be deleted after deleting the vehicle.<br />
# Delete Customer
You can delete your customers and all related items with your customer by clicking the "Delete Customer" button.




