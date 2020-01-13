﻿// 32feet.NET - Personal Area Networking for .NET
//
// InTheHand.Net.Bluetooth.BluetoothProtocol
// 
// Copyright (c) 2003-2020 In The Hand Ltd, All rights reserved.
// This source code is licensed under the MIT License

using System;

namespace InTheHand.Net.Bluetooth
{
    /// <summary>
    /// Standard Bluetooth Protocol identifiers.
    /// </summary>
    /// -
    /// <remarks>
    /// <para>See the list at <see href="http://www.bluetooth.org/Technical/AssignedNumbers/service_discovery.htm"/>.
    /// </para>
    /// <para>The Bluetooth Base UUID is {00000000-0000-1000-8000-00805F9B34FB}
    /// </para>
    /// </remarks>
    public static class BluetoothProtocol
    {
#pragma warning disable 1591
        /// <summary>
        /// [0x0001]
        /// </summary>
        public static readonly Guid SdpProtocol = new Guid(0x00000001, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0002]
        /// </summary>
        public static readonly Guid UdpProtocol = new Guid(0x00000002, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0003]
        /// </summary>
        public static readonly Guid RFCommProtocol = new Guid(0x00000003, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0004]
        /// </summary>
        public static readonly Guid TcpProtocol = new Guid(0x00000004, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0005]
        /// </summary>
        public static readonly Guid TcsBinProtocol = new Guid(0x00000005, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0006]
        /// </summary>
        public static readonly Guid TcsAtProtocol = new Guid(0x00000006, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0008]
        /// </summary>
        public static readonly Guid AttProtocol = new Guid(0x00000007, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0008]
        /// </summary>
        public static readonly Guid ObexProtocol = new Guid(0x00000008, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0009]
        /// </summary>
        public static readonly Guid IPProtocol = new Guid(0x00000009, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x000A]
        /// </summary>
        public static readonly Guid FtpProtocol = new Guid(0x0000000A, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x000C]
        /// </summary>
        public static readonly Guid HttpProtocol = new Guid(0x0000000C, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x000E]
        /// </summary>
        public static readonly Guid WspProtocol = new Guid(0x0000000E, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x000F]
        /// </summary>
        public static readonly Guid BnepProtocol = new Guid(0x0000000F, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0010]
        /// </summary>
        public static readonly Guid UpnpProtocol = new Guid(0x00000010, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0011]
        /// </summary>
        public static readonly Guid HidpProtocol = new Guid(0x00000011, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0012]
        /// </summary>
        public static readonly Guid HardcopyControlChannelProtocol = new Guid(0x00000012, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0014]
        /// </summary>
        public static readonly Guid HardcopyDataChannelProtocol = new Guid(0x00000014, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0016]
        /// </summary>
        public static readonly Guid HardcopyNotificationProtocol = new Guid(0x00000016, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0017]
        /// </summary>
        public static readonly Guid AvctpProtocol = new Guid(0x00000017, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x0019]
        /// </summary>
        public static readonly Guid AvdtpProtocol = new Guid(0x00000019, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x001B]
        /// </summary>
        public static readonly Guid CmtpProtocol = new Guid(0x0000001B, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x001D] ?????
        /// </summary>
        public static readonly Guid UdiCPlaneProtocol = new Guid(0x0000001D, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x001E]
        /// </summary>
        public static readonly Guid McapControlChannelProtocol = new Guid(0x0000001E, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
        /// <summary>
        /// [0x001F]
        /// </summary>
        public static readonly Guid McapDataChannelProtocol = new Guid(0x0000001F, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);

        /// <summary>
        /// [0x0100]
        /// </summary>
        public static readonly Guid L2CapProtocol = new Guid(0x00000100, 0x0000, 0x1000, 0x80, 0x00, 0x00, 0x80, 0x5F, 0x9B, 0x34, 0xFB);
    }
}