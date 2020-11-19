using System;

if(args.Length >= 1)
{
    if (args[0].Contains("clear"))
    {
        ClearData();
    }
    if (args[0].Contains("import"))
    {
        ReadCsv();
    }
    if (args[0].Contains("check"))
    {
        CheckLimit();
    }
}

void CheckLimit()
{
    throw new NotImplementedException();
}

void ReadCsv()
{
    throw new NotImplementedException();
}

void ClearData()
{
    throw new NotImplementedException();
}