using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmLeadTypeEntityVocabulary : SimpleVocabulary
    {
        public smmLeadTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmLeadTypeEntity";
            KeyPrefix = "commonDataModel.smmleadtypeentity";
            KeySeparator = ".";
            Grouping = "/smmLeadTypeEntity";

            AddGroup("Common Data Model smmLeadTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeDescription { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}