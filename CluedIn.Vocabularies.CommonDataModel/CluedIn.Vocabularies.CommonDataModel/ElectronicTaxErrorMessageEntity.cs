using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxErrorMessageEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxErrorMessageEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicTaxErrorMessageEntity";
            KeyPrefix = "commonDataModel.electronictaxerrormessageentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxErrorMessageEntity";

            AddGroup("Common Data Model ElectronicTaxErrorMessageEntity Details", group =>
            {
                ErrorId = group.Add(new VocabularyKey(nameof(ErrorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ErrorType = group.Add(new VocabularyKey(nameof(ErrorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DPErrorCode = group.Add(new VocabularyKey(nameof(DPErrorCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ErrorCode = group.Add(new VocabularyKey(nameof(ErrorCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ErrorText = group.Add(new VocabularyKey(nameof(ErrorText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ErrorId { get; private set; }
public VocabularyKey ErrorType { get; private set; }
public VocabularyKey DPErrorCode { get; private set; }
public VocabularyKey ErrorCode { get; private set; }
public VocabularyKey ErrorText { get; private set; }
public VocabularyKey Company { get; private set; }


    }
}