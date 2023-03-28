using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models;

public class Transaction
{
    
    [Key]
    public int Transactionid{get; set;}
    [Column(TypeName="nvarchar(20)")]    

    public string AccountNumber{get; set;} = null!;
    [Column(TypeName="nvarchar(70)")]
    public string BenificiaryName{get; set;} = null!;

    [Column(TypeName="nvarchar(70)")]
    public string BankName{get; set;} = null!;

    [Column(TypeName="nvarchar(15)")]
    public string IFSC{get; set;} = null!;

    public int Amount{get; set;}

    public DateTime Date{get; set;}
}