using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSUnitOfMeasureConversionSequenceGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSUnitOfMeasureConversionSequenceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSUnitOfMeasureConversionSequenceGroupEntity";
            KeyPrefix = "commonDataModel.whsunitofmeasureconversionsequencegroupentity";
            KeySeparator = ".";
            Grouping = "/WHSUnitOfMeasureConversionSequenceGroupEntity";

            AddGroup("Common Data Model WHSUnitOfMeasureConversionSequenceGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}