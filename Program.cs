

int SideA;
int SideB;
int SideC;
Console.WriteLine("Please Enter the first side");
string temp1=Console.ReadLine();
Console.WriteLine("Please Enter the second side");
string temp2=Console.ReadLine();
Console.WriteLine("Please Enter the third side");
string temp3=Console.ReadLine();

bool Is_parsedA=Int32.TryParse(temp1, out SideA);
bool Is_parsedB=Int32.TryParse(temp2, out SideB);
bool Is_parsedC=Int32.TryParse(temp3, out SideC);

if (Is_parsedA && Is_parsedB && Is_parsedC)
{
    bool is_triangle= SideA + SideB> SideC &&
               SideA + SideC > SideB &&
               SideB + SideC > SideA;
    if (is_triangle)
    {
        Console.WriteLine("It can be a Triangle");
    }
    else {
        Console.WriteLine("This can not be triangle!!!!");
    }

}
else {
    Console.WriteLine("We got invalid Value");
}