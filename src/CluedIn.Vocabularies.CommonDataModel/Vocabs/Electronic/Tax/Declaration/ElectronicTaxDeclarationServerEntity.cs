using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxDeclarationServerEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxDeclarationServerEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicTaxDeclarationServerEntity";
            KeyPrefix = "commonDataModel.electronictaxdeclarationserverentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxDeclarationServerEntity";

            AddGroup("Common Data Model ElectronicTaxDeclarationServerEntity Details", group =>
            {
                InternetAddress = group.Add(new VocabularyKey(nameof(InternetAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InternetAddress { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}