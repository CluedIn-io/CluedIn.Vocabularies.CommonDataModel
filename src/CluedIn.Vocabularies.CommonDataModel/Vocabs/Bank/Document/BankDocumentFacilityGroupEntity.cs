using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankDocumentFacilityGroupEntityVocabulary : SimpleVocabulary
    {
        public BankDocumentFacilityGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankDocumentFacilityGroupEntity";
            KeyPrefix = "commonDataModel.bankdocumentfacilitygroupentity";
            KeySeparator = ".";
            Grouping = "/BankDocumentFacilityGroupEntity";

            AddGroup("Common Data Model BankDocumentFacilityGroupEntity Details", group =>
            {
                FacilityGroup = group.Add(new VocabularyKey(nameof(FacilityGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FacilityGroup { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}