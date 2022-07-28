public class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }


    public virtual void SaveData()
    {
        // Save the vehicle to database
    }

    public void Drive()
    {
        // Drive the vehicle
    }

    public void Park()
    {
        // Park the vehicle
    }

    public void Repair()
    {
        // Repair the vehicle
    }

}

interface Iuser
{
    void CreateUser();
    void AssignVehicleToUser();
    void RemoveVehicleFromUser();


}

public class User : Vehicle , Iuser
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public string UserPhone { get; set; }


    public void CreateUser()
    {

        // Create a user
    }

    public override void SaveData()
    {

        //save the user to database
    }

    public void AssignVehicleToUser()
    {

        // Assign the vehicle to a user
    }

    public void RemoveVehicleFromUser()
    {
        // Remove the vehicle from a user
    }

}