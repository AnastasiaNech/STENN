int X = 10;
int Y = 20;
int Z = 30;

ChangeValue(ref X,ref Y,ref Z);  

Console.WriteLine(X.ToString() + " " + Y.ToString() + " " + Z.ToString());


static void ChangeValue(ref int X, ref int Y, ref int Z)
   {
    X = X ^ Y;
    Y = X ^ Y;
    X = X ^ Y;

    Y = Y ^ Z;
    Z = Z ^ Y;
    Y = Y ^ Z;
}