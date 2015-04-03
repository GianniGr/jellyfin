﻿namespace MediaBrowser.Model.LiveTv
{
    public class RecommendedProgramQuery
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is airing.
        /// </summary>
        /// <value><c>true</c> if this instance is airing; otherwise, <c>false</c>.</value>
        public bool? IsAiring { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has aired.
        /// </summary>
        /// <value><c>null</c> if [has aired] contains no value, <c>true</c> if [has aired]; otherwise, <c>false</c>.</value>
        public bool? HasAired { get; set; }

        /// <summary>
        /// The maximum number of items to return
        /// </summary>
        /// <value>The limit.</value>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is movie.
        /// </summary>
        /// <value><c>null</c> if [is movie] contains no value, <c>true</c> if [is movie]; otherwise, <c>false</c>.</value>
        public bool? IsMovie { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is sports.
        /// </summary>
        /// <value><c>null</c> if [is sports] contains no value, <c>true</c> if [is sports]; otherwise, <c>false</c>.</value>
        public bool? IsSports { get; set; }
    }
}