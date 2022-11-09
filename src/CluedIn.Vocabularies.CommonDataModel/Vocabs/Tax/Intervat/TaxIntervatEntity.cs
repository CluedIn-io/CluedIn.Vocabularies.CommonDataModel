using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxIntervatEntityVocabulary : SimpleVocabulary
    {
        public TaxIntervatEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxIntervatEntity";
            KeyPrefix = "commonDataModel.taxintervatentity";
            KeySeparator = ".";
            Grouping = "/TaxIntervatEntity";

            AddGroup("Common Data Model TaxIntervatEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntervatId = group.Add(new VocabularyKey(nameof(IntervatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnterpriseNumber = group.Add(new VocabularyKey(nameof(EnterpriseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NilAnnualListing = group.Add(new VocabularyKey(nameof(NilAnnualListing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EMail = group.Add(new VocabularyKey(nameof(EMail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Telephone = group.Add(new VocabularyKey(nameof(Telephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestForReimbursement = group.Add(new VocabularyKey(nameof(RequestForReimbursement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Filename = group.Add(new VocabularyKey(nameof(Filename), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodFrequency = group.Add(new VocabularyKey(nameof(PeriodFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestForPaymentForms = group.Add(new VocabularyKey(nameof(RequestForPaymentForms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreparationDate = group.Add(new VocabularyKey(nameof(PreparationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReplacedVATDeclaration = group.Add(new VocabularyKey(nameof(ReplacedVATDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxNumber = group.Add(new VocabularyKey(nameof(SalesTaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Period = group.Add(new VocabularyKey(nameof(Period), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxBox = group.Add(new VocabularyKey(nameof(SalesTaxBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey IntervatId { get; private set; }
public VocabularyKey CompanyName { get; private set; }
public VocabularyKey EnterpriseNumber { get; private set; }
public VocabularyKey NilAnnualListing { get; private set; }
public VocabularyKey EMail { get; private set; }
public VocabularyKey Telephone { get; private set; }
public VocabularyKey RequestForReimbursement { get; private set; }
public VocabularyKey Filename { get; private set; }
public VocabularyKey PeriodFrequency { get; private set; }
public VocabularyKey RequestForPaymentForms { get; private set; }
public VocabularyKey PreparationDate { get; private set; }
public VocabularyKey ReplacedVATDeclaration { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey SalesTaxNumber { get; private set; }
public VocabularyKey Period { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey SalesTaxBox { get; private set; }
public VocabularyKey Amount { get; private set; }


    }
}