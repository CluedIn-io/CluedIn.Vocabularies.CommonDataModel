using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustTableChangeProposalFieldEnablementEntityVocabulary : SimpleVocabulary
    {
        public CustTableChangeProposalFieldEnablementEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustTableChangeProposalFieldEnablementEntity";
            KeyPrefix = "commonDataModel.custtablechangeproposalfieldenablemententity";
            KeySeparator = ".";
            Grouping = "/CustTableChangeProposalFieldEnablementEntity";

            AddGroup("Common Data Model CustTableChangeProposalFieldEnablementEntity Details", group =>
            {
                Field = group.Add(new VocabularyKey(nameof(Field), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsEnabled = group.Add(new VocabularyKey(nameof(IsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Field { get; private set; }
public VocabularyKey IsEnabled { get; private set; }


    }
}