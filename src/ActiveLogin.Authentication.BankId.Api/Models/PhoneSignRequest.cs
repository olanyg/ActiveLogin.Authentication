namespace ActiveLogin.Authentication.BankId.Api.Models;

/// <summary>
/// Phone sign request parameters.
/// </summary>
public class PhoneSignRequest : PhoneRequest
{
    /// <summary></summary>
    /// <param name="personalIdentityNumber">
    /// The personal number of the user. String. 12 digits.
    /// </param>
    /// <param name="callInitiator">
    /// Indicate if the user or the RP initiated the phone call. user: user called the RP. RP: RP called the user.
    /// </param>
    /// <param name="userVisibleData">
    /// The text to be displayed and signed. The text can be formatted using CR, LF and CRLF for new lines.
    /// </param>
    /// <param name="userNonVisibleData">
    /// Data not displayed to the user.
    /// </param>
    /// <param name="requirement">Requirements on how the phone auth or phone sign order must be performed.</param>
    /// <param name="userVisibleDataFormat">
    /// If present, and set to "simpleMarkdownV1", this parameter indicates that userVisibleData holds formatting characters which, if used correctly, will make the text displayed with the user nicer to look at.
    /// For further information of formatting options, please study the document Guidelines for Formatted Text.
    /// </param>
    public PhoneSignRequest(
        string personalIdentityNumber,
        CallInitiator callInitiator,
        string userVisibleData,
        byte[]? userNonVisibleData = null,
        PhoneRequirement? requirement = null,
        string? userVisibleDataFormat = null)
        : base(personalIdentityNumber, callInitiator, userVisibleData, userNonVisibleData, requirement, userVisibleDataFormat)
    {
    }
}
