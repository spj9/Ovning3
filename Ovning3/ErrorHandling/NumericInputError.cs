using System;

//NumericInputError-klassen ärver från UserError
class NumericInputError : UserError
{
    public override string Message()
    {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}