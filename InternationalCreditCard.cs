class InternationalCreditCard 
{
    private decimal Creditlimit;
    #region CreditLimit
    //Hạn mức giao dịch tín dụng
    #endregion
    public decimal CreditLimit
    {
        get; set;
    }
    private decimal poslimit;
    #region CreditLimit
    //Hạn mức giao dịch tại pos atm
    #endregion
    public decimal POSLimit
    {
        get; set;
    }
    private decimal atmlimit;
    #region ATMLimit
    //Hạn mức giao dịch tại pos atm
    #endregion
    public decimal ATMLimit
    {
        get; set;
    }
    private decimal Ipolimit;
    #region Initial Public Offering
    //Phát hành công khai lần đầu, còn gọi là IPO
    #endregion
    public decimal IPOLimit
    {
        get; set;
    }
    private decimal Poglimit;
    #region Payment of good
    //Thanh toán hàng hóa/dịch vụ
    #endregion
    public decimal POGLimit
    {
        get; set;
    }
    private decimal Annualfees;
    #region Annual fees
    //Phí thường niên
    #endregion
    public decimal AnnualFees
    {
        get; set;
    }
    private decimal internetlimit;
    #region Deal Internet/Moto
    //Giao dịch Internet/MOTO
    #endregion
    public decimal InternetLimit
    {
        get; set;
    }
    private string typecard;
    public string Typecard
    {
        get; set;
    }
    private float creditinterestrate;
    public float CreditInterestRate
    {
        get; set;
    }
    private decimal creditcardbalance;
    public decimal CreditCardBalance
    {
        get; set;
    }
    private DateTime duedate;
    public DateTime Duedate
    {
        get; set;
    }
    private decimal minimumpayment;
    public decimal Minimumpayment
    {
        get; set;
    }
    public InternationalCreditCard(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment)
    {
        AnnualFees = annualFees;

        CreditLimit = creditLimit;
        POSLimit = CreditLimit / 2;
        POGLimit = poglimit;
        ATMLimit = atmlimit;
        InternetLimit = internetlimit;
        IPOLimit = ipolimit;

        Typecard = typecard;
        CreditInterestRate = creditinterestrate;
        CreditCardBalance = creditcardbalance;
        Duedate = duedate;
        Minimumpayment = minimumpayment;
    }
    ~InternationalCreditCard()
    { }
}
class VisaStandard : InternationalCreditCard
{

    public VisaStandard(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment) :
        base(annualFees, creditLimit, poglimit, atmlimit, internetlimit, ipolimit, typecard, creditinterestrate, creditcardbalance, duedate, minimumpayment)
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "Visa Standard";
        this.CreditCardBalance = creditcardbalance;
        this.CreditInterestRate = creditinterestrate;
        this.Duedate = duedate;
        this.Minimumpayment = minimumpayment;

    }
    ~VisaStandard()
    { }

}
class VisaGold : InternationalCreditCard
{
    public VisaGold(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment) :
        base(annualFees, creditLimit, poglimit, atmlimit, internetlimit, ipolimit, typecard, creditinterestrate, creditcardbalance, duedate, minimumpayment)
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "VisaGold";
        this.CreditCardBalance = creditcardbalance;
        this.CreditInterestRate = creditinterestrate;
        this.Duedate = duedate;
        this.Minimumpayment = minimumpayment;

    }
    ~VisaGold()
    { }
}

class MastercardGold : InternationalCreditCard
{
    public MastercardGold(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment) :
        base(annualFees, creditLimit, poglimit, atmlimit, internetlimit, ipolimit, typecard, creditinterestrate, creditcardbalance, duedate, minimumpayment)
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "MastercardGold";
        this.CreditCardBalance = creditcardbalance;
        this.CreditInterestRate = creditinterestrate;
        this.Duedate = duedate;
        this.Minimumpayment = minimumpayment;

    }
    ~MastercardGold()
    { }
}
class MastercardPlatinum : InternationalCreditCard
{
    public MastercardPlatinum(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment) :
        base(annualFees, creditLimit, poglimit, atmlimit, internetlimit, ipolimit, typecard, creditinterestrate, creditcardbalance, duedate, minimumpayment)
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "MastercardPlatinum";
        this.CreditCardBalance = creditcardbalance;
        this.CreditInterestRate = creditinterestrate;
        this.Duedate = duedate;
        this.Minimumpayment = minimumpayment;

    }
    ~MastercardPlatinum()
    { }
}
class JCBGold : InternationalCreditCard
{
    public JCBGold(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment) :
        base(annualFees, creditLimit, poglimit, atmlimit, internetlimit, ipolimit, typecard, creditinterestrate, creditcardbalance, duedate, minimumpayment)
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "JCBUltimate";
        this.CreditCardBalance = creditcardbalance;
        this.CreditInterestRate = creditinterestrate;
        this.Duedate = duedate;
        this.Minimumpayment = minimumpayment;

    }
    ~JCBGold()
    { }
}
class JCBUltimate : InternationalCreditCard
{
    public JCBUltimate(decimal annualFees, decimal creditLimit, decimal poglimit, decimal atmlimit,
        decimal internetlimit, decimal ipolimit, string typecard, float creditinterestrate, decimal creditcardbalance,
        DateTime duedate, decimal minimumpayment) :
        base(annualFees, creditLimit, poglimit, atmlimit, internetlimit, ipolimit, typecard, creditinterestrate, creditcardbalance, duedate, minimumpayment)
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "JCBUltimate";
        this.CreditCardBalance = creditcardbalance;
        this.CreditInterestRate = creditinterestrate;
        this.Duedate = duedate;
        this.Minimumpayment = minimumpayment;

    }
    ~JCBUltimate()
    { }
}