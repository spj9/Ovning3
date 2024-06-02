using System;

//NullError-klassen ärver från UserError
class NullError : UserError
{
    public override string Message()
    {
        return "You didn't input anything. This fired an error!";
    }
}