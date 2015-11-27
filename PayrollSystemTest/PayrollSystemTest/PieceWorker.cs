using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PieceWorker : Employee
{
    //declare private wage per piece variable
    private decimal wage;
    //declare private variable for pieces
    private decimal pieces;

    //constructor that accepts base paramaters and adds two more
    public PieceWorker(string first, string last, string ssn,
        decimal piecesWage, decimal piecesMade)
        : base(first, last, ssn)
    {

        WageP = piecesWage;
        Pieces = piecesMade;
    }

    //creates get and set methods for WageP, to return wage per piece
    public decimal WageP
    {
        get
        {
            return wage;
        }
        set
        {
            //checks to see if the value iss not 0 or less
            if (value >= 0)
                wage = value;
            else
                throw new ArgumentOutOfRangeException("Wage", value, " Wage must be >=0");
        }
    }

    //creates get and set methods for Pieces, to return value of number of pieces created
    public decimal Pieces
    {
        get
        {
            return pieces;
        }
        set
        {
            //checks to see if pieces do not equal 0
            if (value >= 0)
                pieces = value;
            else
                throw new ArgumentOutOfRangeException("Pieces", value, " Pieces must be >=0");
        }
    }

    //overrides Employees earnings method
    public override decimal Earnings()
    {
        //returns earnings
        return WageP * Pieces;
    }

    //overrides To String method, to inclue piece wages and pieces made
    public override string ToString()
    {
        return string.Format("piece employee: {0}\n{1}: {2:C}; {3}: {4:F2}",
     base.ToString(), "pay per piece", WageP, "pieces made", Pieces);
    }
}
