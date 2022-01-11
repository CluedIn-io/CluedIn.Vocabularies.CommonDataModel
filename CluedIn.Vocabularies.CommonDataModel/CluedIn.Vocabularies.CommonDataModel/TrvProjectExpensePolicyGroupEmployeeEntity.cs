using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvProjectExpensePolicyGroupEmployeeEntityVocabulary : SimpleVocabulary
    {
        public TrvProjectExpensePolicyGroupEmployeeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvProjectExpensePolicyGroupEmployeeEntity";
            KeyPrefix = "commonDataModel.trvprojectexpensepolicygroupemployeeentity";
            KeySeparator = ".";
            Grouping = "/TrvProjectExpensePolicyGroupEmployeeEntity";

            AddGroup("Common Data Model TrvProjectExpensePolicyGroupEmployeeEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }


    }
}