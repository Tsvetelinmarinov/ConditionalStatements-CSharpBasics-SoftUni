/**
 * 07. Area of Figures
 */


// square, rectangle, circle или triangle

double figureArea = 0.0;


string figureType = Console.ReadLine();



if (figureType == "square")
{
    double squareSide = double.Parse(Console.ReadLine());
    figureArea = Math.Pow(squareSide, 2);
}
else if (figureType == "rectangle")
{
    double squareLength = double.Parse(Console.ReadLine());
    double squareHeigth = double.Parse(Console.ReadLine());
    figureArea = squareLength * squareHeigth;
}
else if (figureType == "circle")
{
    double circleRadius = double.Parse(Console.ReadLine());
    figureArea = Math.PI * Math.Pow(circleRadius, 2);
}
else if (figureType == "triangle")
{
    double triangleSide = double.Parse(Console.ReadLine());
    double heigth = double.Parse(Console.ReadLine());
    figureArea = triangleSide * heigth / 2;
}



Console.WriteLine($"{figureArea:F3}");