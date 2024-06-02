using System;

//TextInputError-klassen ärver från UserError
class TextInputError : UserError
{
    public override string Message()
    {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}