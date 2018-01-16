﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Configuration;
using SafeExamBrowser.Contracts.I18n;

namespace SafeExamBrowser.Core.Notifications
{
	class LogNotificationInfo : INotificationInfo
	{
		private IText text;

		public string Tooltip => text.Get(TextKey.Notification_LogTooltip);
		public IIconResource IconResource { get; } = new LogNotificationIconResource();

		public LogNotificationInfo(IText text)
		{
			this.text = text;
		}
	}
}
