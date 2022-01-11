using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsProfileEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model RDeferralsProfileEntity";
            KeyPrefix = "commonDataModel.rdeferralsprofileentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsProfileEntity";

            AddGroup("Common Data Model RDeferralsProfileEntity Details", group =>
            {
                CalculationPeriod = group.Add(new VocabularyKey(nameof(CalculationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WritingOffPeriod = group.Add(new VocabularyKey(nameof(WritingOffPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WritingOffMethod = group.Add(new VocabularyKey(nameof(WritingOffMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WritingOffProfile = group.Add(new VocabularyKey(nameof(WritingOffProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculationType = group.Add(new VocabularyKey(nameof(CalculationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundOffOperation = group.Add(new VocabularyKey(nameof(RoundOffOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CalculationPeriod { get; private set; }
public VocabularyKey WritingOffPeriod { get; private set; }
public VocabularyKey WritingOffMethod { get; private set; }
public VocabularyKey WritingOffProfile { get; private set; }
public VocabularyKey CalculationType { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey RoundOffOperation { get; private set; }


    }
}