using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAgreementClassificationEntityVocabulary : SimpleVocabulary
    {
        public SalesAgreementClassificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesAgreementClassificationEntity";
            KeyPrefix = "commonDataModel.salesagreementclassificationentity";
            KeySeparator = ".";
            Grouping = "/SalesAgreementClassificationEntity";

            AddGroup("Common Data Model SalesAgreementClassificationEntity Details", group =>
            {
                ClassificationDescription = group.Add(new VocabularyKey(nameof(ClassificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClassificationName = group.Add(new VocabularyKey(nameof(ClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ClassificationDescription { get; private set; }
public VocabularyKey ClassificationName { get; private set; }


    }
}