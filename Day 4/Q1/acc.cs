namespace program
{
    class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        static float Interestrate=0.07f;
    const float minbalance=1000f;

    static Account()
    {
        Console.WriteLine("SBI BANK");
    }
        public Account(string name,double balance)
        {
            if(balance<=0)
            {
                throw new Exception("Balance is Low");
            }
            else
            {
            Name=name;
            this.balance=balance;
            id=++getid;
            }
        }

        public int Id
        {
            get{
                return id;              //Read-only ID
            }
        }

         public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if(value.Length<3 && value.Length>12)           //Error
          
            name=value;
            else
            {
                throw new Exception("Name Char Less");
            }
        }
        
    }

    public double Balance
    {
        get{
            return balance;
        }
        set{
            balance=value;
        }
    }

    public void deposit(int amt)
    {
        if(amt<=0)
        {
            throw new Exception("Can't add 0 & Negative Value");
        }
        balance+=amt;
    }

    
    public void withdraw(int amt)
    {
        
       if(amt<=0)
        {
            throw new Exception("Can't add 0 & Negative Value");
        }

        else if(balance-amt<minbalance)
        {
            throw new Exception("Min Balance");
        }
        else 
        balance-=amt;
    }

    public static double Income(Account obj)
    {
        double income=obj.balance*Interestrate;
        obj.balance=obj.balance+income;
        return obj.balance;

    }

    public string display()
    {
        return "ID: "+id+"  Name: "+name+" Balance: "+balance;
    }

    }
}