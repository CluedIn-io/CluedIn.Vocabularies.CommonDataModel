using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysEmailParametersEntityVocabulary : SimpleVocabulary
    {
        public SysEmailParametersEntityVocabulary()
        {
            VocabularyName = "Sys Email Parameters Entity";
            KeyPrefix = "commonDataModel.sysemailparametersentity";
            KeySeparator = ".";
            Grouping = "/SysEmailParametersEntity";

            AddGroup("SysEmailParametersEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumEmailAttachmentSize = group.Add(new VocabularyKey(nameof(MaximumEmailAttachmentSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SMTPUseNTLM = group.Add(new VocabularyKey(nameof(SMTPUseNTLM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SMTPPortNumber = group.Add(new VocabularyKey(nameof(SMTPPortNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SMTPRelayServerName = group.Add(new VocabularyKey(nameof(SMTPRelayServerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SMTPUserName = group.Add(new VocabularyKey(nameof(SMTPUserName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SMTPRequireSSL = group.Add(new VocabularyKey(nameof(SMTPRequireSSL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailerNonInteractive = group.Add(new VocabularyKey(nameof(MailerNonInteractive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailerInteractiveEnabled = group.Add(new VocabularyKey(nameof(MailerInteractiveEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey MaximumEmailAttachmentSize { get; private set; }
        public VocabularyKey SMTPUseNTLM { get; private set; }
        public VocabularyKey SMTPPortNumber { get; private set; }
        public VocabularyKey SMTPRelayServerName { get; private set; }
        public VocabularyKey SMTPUserName { get; private set; }
        public VocabularyKey SMTPRequireSSL { get; private set; }
        public VocabularyKey MailerNonInteractive { get; private set; }
        public VocabularyKey MailerInteractiveEnabled { get; private set; }
    }
}