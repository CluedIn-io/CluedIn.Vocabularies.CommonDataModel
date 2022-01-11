using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorCertificationTypeEntityVocabulary : SimpleVocabulary
    {
        public VendVendorCertificationTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendVendorCertificationTypeEntity";
            KeyPrefix = "commonDataModel.vendvendorcertificationtypeentity";
            KeySeparator = ".";
            Grouping = "/VendVendorCertificationTypeEntity";

            AddGroup("Common Data Model VendVendorCertificationTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}