using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OfficeAddinLegalEntityEntityVocabulary : SimpleVocabulary
    {
        public OfficeAddinLegalEntityEntityVocabulary()
        {
            VocabularyName = "Common Data Model OfficeAddinLegalEntityEntity";
            KeyPrefix = "commonDataModel.officeaddinlegalentityentity";
            KeySeparator = ".";
            Grouping = "/OfficeAddinLegalEntityEntity";

            AddGroup("Common Data Model OfficeAddinLegalEntityEntity Details", group =>
            {
                CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessActivity = group.Add(new VocabularyKey(nameof(BusinessActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessActivityDescription = group.Add(new VocabularyKey(nameof(BusinessActivityDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatFileNumber = group.Add(new VocabularyKey(nameof(ZakatFileNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CompanyName { get; private set; }
public VocabularyKey CompanyId { get; private set; }
public VocabularyKey BusinessActivity { get; private set; }
public VocabularyKey BusinessActivityDescription { get; private set; }
public VocabularyKey ZakatFileNumber { get; private set; }


    }
}