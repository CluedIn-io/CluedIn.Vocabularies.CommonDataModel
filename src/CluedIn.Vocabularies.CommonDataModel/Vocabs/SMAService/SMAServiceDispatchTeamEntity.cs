using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceDispatchTeamEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceDispatchTeamEntityVocabulary()
        {
            VocabularyName = "SMAServiceDispatchTeamEntity";
            KeyPrefix = "commonDataModel.smaservicedispatchteamentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceDispatchTeamEntity";

            AddGroup("SMAServiceDispatchTeamEntity Details", group =>
            {
                TeamDescription = group.Add(new VocabularyKey(nameof(TeamDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamId = group.Add(new VocabularyKey(nameof(TeamId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamResponsibleRecId = group.Add(new VocabularyKey(nameof(TeamResponsibleRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(TeamResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TeamDescription { get; private set; }
        public VocabularyKey TeamId { get; private set; }
        public VocabularyKey TeamResponsibleRecId { get; private set; }
        public VocabularyKey TeamResponsiblePersonnelNumber { get; private set; }


    }
}