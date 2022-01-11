using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class YearlyTaxCommunicationSetupEntityVocabulary : SimpleVocabulary
    {
        public YearlyTaxCommunicationSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model YearlyTaxCommunicationSetupEntity";
            KeyPrefix = "commonDataModel.yearlytaxcommunicationsetupentity";
            KeySeparator = ".";
            Grouping = "/YearlyTaxCommunicationSetupEntity";

            AddGroup("Common Data Model YearlyTaxCommunicationSetupEntity Details", group =>
            {
                FieldID = group.Add(new VocabularyKey(nameof(FieldID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Calculation = group.Add(new VocabularyKey(nameof(Calculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Tax = group.Add(new VocabularyKey(nameof(Tax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Sign = group.Add(new VocabularyKey(nameof(Sign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NondeductibleSalesTax = group.Add(new VocabularyKey(nameof(NondeductibleSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalSign = group.Add(new VocabularyKey(nameof(TotalSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalFieldID = group.Add(new VocabularyKey(nameof(TotalFieldID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FieldID { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Format { get; private set; }
public VocabularyKey Calculation { get; private set; }
public VocabularyKey Value { get; private set; }
public VocabularyKey Tax { get; private set; }
public VocabularyKey Sign { get; private set; }
public VocabularyKey NondeductibleSalesTax { get; private set; }
public VocabularyKey TotalSign { get; private set; }
public VocabularyKey TotalFieldID { get; private set; }
public VocabularyKey SalesTaxCode { get; private set; }


    }
}