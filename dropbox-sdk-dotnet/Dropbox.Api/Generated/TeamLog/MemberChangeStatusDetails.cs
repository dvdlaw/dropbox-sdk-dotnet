// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed the membership status of a team member.</para>
    /// </summary>
    public class MemberChangeStatusDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberChangeStatusDetails> Encoder = new MemberChangeStatusDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberChangeStatusDetails> Decoder = new MemberChangeStatusDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberChangeStatusDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New member status.</param>
        /// <param name="previousValue">Previous member status. Might be missing due to
        /// historical data gap.</param>
        /// <param name="teamJoinDetails">Additional information relevant when a new member
        /// joins the team.</param>
        public MemberChangeStatusDetails(MemberStatus newValue,
                                         MemberStatus previousValue = null,
                                         JoinTeamDetails teamJoinDetails = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
            this.TeamJoinDetails = teamJoinDetails;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberChangeStatusDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberChangeStatusDetails()
        {
        }

        /// <summary>
        /// <para>New member status.</para>
        /// </summary>
        public MemberStatus NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous member status. Might be missing due to historical data gap.</para>
        /// </summary>
        public MemberStatus PreviousValue { get; protected set; }

        /// <summary>
        /// <para>Additional information relevant when a new member joins the team.</para>
        /// </summary>
        public JoinTeamDetails TeamJoinDetails { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberChangeStatusDetails" />.</para>
        /// </summary>
        private class MemberChangeStatusDetailsEncoder : enc.StructEncoder<MemberChangeStatusDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberChangeStatusDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.MemberStatus.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.MemberStatus.Encoder);
                }
                if (value.TeamJoinDetails != null)
                {
                    WriteProperty("team_join_details", value.TeamJoinDetails, writer, global::Dropbox.Api.TeamLog.JoinTeamDetails.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberChangeStatusDetails" />.</para>
        /// </summary>
        private class MemberChangeStatusDetailsDecoder : enc.StructDecoder<MemberChangeStatusDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberChangeStatusDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberChangeStatusDetails Create()
            {
                return new MemberChangeStatusDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberChangeStatusDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.MemberStatus.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.MemberStatus.Decoder.Decode(reader);
                        break;
                    case "team_join_details":
                        value.TeamJoinDetails = global::Dropbox.Api.TeamLog.JoinTeamDetails.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
