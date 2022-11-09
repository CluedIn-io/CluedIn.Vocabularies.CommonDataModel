using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGSTRegistrationNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxGSTRegistrationNumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGSTRegistrationNumberEntity";
            KeyPrefix = "commonDataModel.taxgstregistrationnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxGSTRegistrationNumberEntity";

            AddGroup("Common Data Model TaxGSTRegistrationNumberEntity Details", group =>
            {
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Shared = group.Add(new VocabularyKey(nameof(Shared), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegistrationNumberType = group.Add(new VocabularyKey(nameof(RegistrationNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NameOfTaxablePerson = group.Add(new VocabularyKey(nameof(NameOfTaxablePerson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessVerticals = group.Add(new VocabularyKey(nameof(BusinessVerticals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TurnOver = group.Add(new VocabularyKey(nameof(TurnOver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CasualDescription = group.Add(new VocabularyKey(nameof(CasualDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CasualFromDate = group.Add(new VocabularyKey(nameof(CasualFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CasualToDate = group.Add(new VocabularyKey(nameof(CasualToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxType { get; private set; }
public VocabularyKey Shared { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey RefCompanyId { get; private set; }
public VocabularyKey RegistrationNumber { get; private set; }
public VocabularyKey RegistrationNumberType { get; private set; }
public VocabularyKey NameOfTaxablePerson { get; private set; }
public VocabularyKey BusinessVerticals { get; private set; }
public VocabularyKey TurnOver { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey CasualDescription { get; private set; }
public VocabularyKey CasualFromDate { get; private set; }
public VocabularyKey CasualToDate { get; private set; }


    }
}