﻿using Harion.Enumerations;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Harion.Utility.Utils {
    public static class PositionUtils {

        public readonly static List<PositionData> MapLocations = new() {
            new PositionData(MapType.Skeld, new Vector2(-1.119f, 5.854f), SystemTypes.Cafeteria),
            new PositionData(MapType.Skeld, new Vector2(-5.611f, 4.211f), SystemTypes.Cafeteria),
            new PositionData(MapType.Skeld, new Vector2(2.722f, -2.377f), SystemTypes.Cafeteria),
            new PositionData(MapType.Skeld, new Vector2(-5.091f, -2.597f), SystemTypes.Cafeteria),
            new PositionData(MapType.Skeld, new Vector2(11.186f, 2.000f), SystemTypes.Weapons),
            new PositionData(MapType.Skeld, new Vector2(6.664f, -4.640f), SystemTypes.LifeSupp),
            new PositionData(MapType.Skeld, new Vector2(5.234f, -4.717f), SystemTypes.LifeSupp),
            new PositionData(MapType.Skeld, new Vector2(17.912f, -5.758f), SystemTypes.Nav),
            new PositionData(MapType.Skeld, new Vector2(15.798f, -6.275f), SystemTypes.Nav),
            new PositionData(MapType.Skeld, new Vector2(11.333f, -10.383f), SystemTypes.Shields),
            new PositionData(MapType.Skeld, new Vector2(7.688f, -14.272f), SystemTypes.Shields),
            new PositionData(MapType.Skeld, new Vector2(1.982f, -14.939f), SystemTypes.Comms),
            new PositionData(MapType.Skeld, new Vector2(6.165f, -15.436f), SystemTypes.Comms),
            new PositionData(MapType.Skeld, new Vector2(2.563f, -16.769f), SystemTypes.Comms),
            new PositionData(MapType.Skeld, new Vector2(-2.920f, -16.862f), SystemTypes.Storage),
            new PositionData(MapType.Skeld, new Vector2(-4.747f, -10.854f), SystemTypes.Storage),
            new PositionData(MapType.Skeld, new Vector2(0.597f, -9.126f), SystemTypes.Storage),
            new PositionData(MapType.Skeld, new Vector2(-2.639f, -9.032f), SystemTypes.Storage),
            new PositionData(MapType.Skeld, new Vector2(4.723f, -9.723f), SystemTypes.Admin),
            new PositionData(MapType.Skeld, new Vector2(6.460f, -6.668f), SystemTypes.Admin),
            new PositionData(MapType.Skeld, new Vector2(-10.738f, -2.095f), SystemTypes.Medical),
            new PositionData(MapType.Skeld, new Vector2(-7.488f, -2.095f), SystemTypes.Medical),
            new PositionData(MapType.Skeld, new Vector2(-10.469f, -4.977f), SystemTypes.Medical),
            new PositionData(MapType.Skeld, new Vector2(-18.545f, 2.453f), SystemTypes.UpperEngine),
            new PositionData(MapType.Skeld, new Vector2(-22.427f, -7.951f), SystemTypes.Reactor),
            new PositionData(MapType.Skeld, new Vector2(-19.564f, -6.895f), SystemTypes.Reactor),
            new PositionData(MapType.Skeld, new Vector2(-22.722f, -3.243f), SystemTypes.Reactor),
            new PositionData(MapType.Skeld, new Vector2(-13.833f, -6.890f), SystemTypes.Security),
            new PositionData(MapType.Skeld, new Vector2(-12.344f, -4.267f), SystemTypes.Security),
            new PositionData(MapType.Skeld, new Vector2(-19.102f, -9.447f), SystemTypes.LowerEngine),
            new PositionData(MapType.Skeld, new Vector2(-17.184f, -13.575f), SystemTypes.LowerEngine),
            new PositionData(MapType.Skeld, new Vector2(-7.830f, -11.982f), SystemTypes.Electrical),
            new PositionData(MapType.Skeld, new Vector2(-5.396f, -7.858f), SystemTypes.Electrical),
            new PositionData(MapType.Skeld, new Vector2(-9.216f, -9.027f), SystemTypes.Electrical),

            new PositionData(MapType.MiraHQ, new Vector2(18.218f, -3.173f), SystemTypes.Balcony),
            new PositionData(MapType.MiraHQ, new Vector2(19.421f, -1.362f), SystemTypes.Balcony),
            new PositionData(MapType.MiraHQ, new Vector2(28.117f, -2.177f), SystemTypes.Balcony),
            new PositionData(MapType.MiraHQ, new Vector2(28.638f, 0.015f), SystemTypes.Cafeteria),
            new PositionData(MapType.MiraHQ, new Vector2(28.183f, 2.656f), SystemTypes.Cafeteria),
            new PositionData(MapType.MiraHQ, new Vector2(28.971f, 4.318f), SystemTypes.Cafeteria),
            new PositionData(MapType.MiraHQ, new Vector2(18.370f, -0.154f), SystemTypes.Cafeteria),
            new PositionData(MapType.MiraHQ, new Vector2(20.642f, 4.807f), SystemTypes.Storage),
            new PositionData(MapType.MiraHQ, new Vector2(18.255f, 5.129f), SystemTypes.Storage),
            new PositionData(MapType.MiraHQ, new Vector2(17.790f, 11.429f), SystemTypes.Hallway),
            new PositionData(MapType.MiraHQ, new Vector2(13.968f, 17.317f), SystemTypes.Electrical),
            new PositionData(MapType.MiraHQ, new Vector2(13.281f, 18.816f), SystemTypes.Electrical),
            new PositionData(MapType.MiraHQ, new Vector2(16.305f, 20.629f), SystemTypes.Electrical),
            new PositionData(MapType.MiraHQ, new Vector2(13.197f, 19.745f), SystemTypes.Electrical),
            new PositionData(MapType.MiraHQ, new Vector2(22.384f, 19.049f), SystemTypes.Admin),
            new PositionData(MapType.MiraHQ, new Vector2(20.257f, 21.095f), SystemTypes.Admin),
            new PositionData(MapType.MiraHQ, new Vector2(22.597f, 22.309f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(13.507f, 23.385f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(14.795f, 24.733f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(16.964f, 25.419f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(19.190f, 25.374f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(21.003f, 24.294f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(21.896f, 23.298f), SystemTypes.Greenhouse),
            new PositionData(MapType.MiraHQ, new Vector2(16.142f, 2.952f), SystemTypes.Comms),
            new PositionData(MapType.MiraHQ, new Vector2(13.911f, 5.564f), SystemTypes.Comms),
            new PositionData(MapType.MiraHQ, new Vector2(9.164f, 5.145f), SystemTypes.LockerRoom),
            new PositionData(MapType.MiraHQ, new Vector2(10.164f, 5.145f), SystemTypes.LockerRoom),
            new PositionData(MapType.MiraHQ, new Vector2(10.490f, 0.550f), SystemTypes.LockerRoom),
            new PositionData(MapType.MiraHQ, new Vector2(3.968f, 0.553f), SystemTypes.LockerRoom),
            new PositionData(MapType.MiraHQ, new Vector2(0.424f, 10.082f), SystemTypes.Reactor),
            new PositionData(MapType.MiraHQ, new Vector2(0.411f, 14.278f), SystemTypes.Reactor),
            new PositionData(MapType.MiraHQ, new Vector2(2.461f, 13.263f), SystemTypes.Reactor),
            new PositionData(MapType.MiraHQ, new Vector2(4.511f, 13.235f), SystemTypes.Reactor),
            new PositionData(MapType.MiraHQ, new Vector2(11.755f, 10.301f), SystemTypes.Laboratory),
            new PositionData(MapType.MiraHQ, new Vector2(14.121f, -1.391f), SystemTypes.MedBay),
            new PositionData(MapType.MiraHQ, new Vector2(16.752f, -1.391f), SystemTypes.MedBay),
            new PositionData(MapType.MiraHQ, new Vector2(14.858f, 1.680f), SystemTypes.MedBay),
            new PositionData(MapType.MiraHQ, new Vector2(-5.863f, -1.970f), SystemTypes.Launchpad),
            new PositionData(MapType.MiraHQ, new Vector2(-6.386f, 0.607f), SystemTypes.Launchpad),

            new PositionData(MapType.Polus, new Vector2(3.802f, -7.584f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(4.464f, -3.384f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(23.939f, -2.409f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(25.305f, -7.380f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(32.133f, -13.230f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(32.680f, -15.732f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(17.785f, -13.163f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(6.801f, -15.427f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(6.706f, -17.387f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(9.186f, -25.456f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(5.045f, -24.722f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(14.017f, -25.674f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(18.086f, -25.685f), SystemTypes.Outside),
            new PositionData(MapType.Polus, new Vector2(12.675f, -17.153f), SystemTypes.Comms),
            new PositionData(MapType.Polus, new Vector2(12.670f, -24.600f), SystemTypes.Weapons),
            new PositionData(MapType.Polus, new Vector2(1.479f, -18.752f), SystemTypes.BoilerRoom),
            new PositionData(MapType.Polus, new Vector2(2.290f, -24.562f), SystemTypes.LifeSupp),
            new PositionData(MapType.Polus, new Vector2(0.654f, -15.818f), SystemTypes.LifeSupp),
            new PositionData(MapType.Polus, new Vector2(3.923f, -11.357f), SystemTypes.Security),
            new PositionData(MapType.Polus, new Vector2(7.373f, -12.808f), SystemTypes.Electrical),
            new PositionData(MapType.Polus, new Vector2(20.809f, -12.475f), SystemTypes.Storage),
            new PositionData(MapType.Polus, new Vector2(34.746f, -5.231f), SystemTypes.Laboratory),
            new PositionData(MapType.Polus, new Vector2(40.223f, -8.095f), SystemTypes.Laboratory),
            new PositionData(MapType.Polus, new Vector2(36.505f, -21.401f), SystemTypes.Specimens),
            new PositionData(MapType.Polus, new Vector2(36.505f, -21.401f), SystemTypes.Specimens),
            new PositionData(MapType.Polus, new Vector2(25.037f, -20.522f), SystemTypes.Admin),
            new PositionData(MapType.Polus, new Vector2(22.388f, -20.522f), SystemTypes.Admin),
            new PositionData(MapType.Polus, new Vector2(22.124f, -25.034f), SystemTypes.Admin),
            new PositionData(MapType.Polus, new Vector2(20.122f, -24.562f), SystemTypes.Admin),
            new PositionData(MapType.Polus, new Vector2(22.987f, -16.659f), SystemTypes.Office),
            new PositionData(MapType.Polus, new Vector2(24.091f, -16.289f), SystemTypes.Office),

            new PositionData(MapType.Airship, new Vector2(17.167f, 14.965f), SystemTypes.MeetingRoom),
            new PositionData(MapType.Airship, new Vector2(6.596f, 14.094f), SystemTypes.MeetingRoom),
            new PositionData(MapType.Airship, new Vector2(3.384f, 16.044f), SystemTypes.MeetingRoom),
            new PositionData(MapType.Airship, new Vector2(3.125f, 6.645f), SystemTypes.GapRoom),
            new PositionData(MapType.Airship, new Vector2(-9.987f, 7.414f), SystemTypes.VaultRoom),
            new PositionData(MapType.Airship, new Vector2(-8.782f, 5.066f), SystemTypes.VaultRoom),
            new PositionData(MapType.Airship, new Vector2(-7.511f, 9.955f), SystemTypes.VaultRoom),
            new PositionData(MapType.Airship, new Vector2(-8.643f, 12.658f), SystemTypes.VaultRoom),
            new PositionData(MapType.Airship, new Vector2(-12.147f, 11.341f), SystemTypes.VaultRoom),
            new PositionData(MapType.Airship, new Vector2(1.564f, -2.582F), SystemTypes.Engine),
            new PositionData(MapType.Airship, new Vector2(-1.168f, -2.653F), SystemTypes.Engine),
            new PositionData(MapType.Airship, new Vector2(-4.210f, 1.352f), SystemTypes.Engine),
            new PositionData(MapType.Airship, new Vector2(-11.889f, 3.271f), SystemTypes.Comms),
            new PositionData(MapType.Airship, new Vector2(-16.754f, 0.866f), SystemTypes.Admin),
            new PositionData(MapType.Airship, new Vector2(-24.405f, -1.148f), SystemTypes.Admin),
            new PositionData(MapType.Airship, new Vector2(-16.802f, -3.377f), SystemTypes.Admin),
            new PositionData(MapType.Airship, new Vector2(-14.156f, -5.083f), SystemTypes.Armory),
            new PositionData(MapType.Airship, new Vector2(-14.000f, -7.851f), SystemTypes.Armory),
            new PositionData(MapType.Airship, new Vector2(-6.947f, -6.572f), SystemTypes.Kitchen),
            new PositionData(MapType.Airship, new Vector2(-2.481f, -9.068f), SystemTypes.Kitchen),
            new PositionData(MapType.Airship, new Vector2(-16.741f, -12.845f), SystemTypes.ViewingDeck),
            new PositionData(MapType.Airship, new Vector2(-13.910f, -16.303f), SystemTypes.ViewingDeck),
            new PositionData(MapType.Airship, new Vector2(4.948f, -10.011f), SystemTypes.Security),
            new PositionData(MapType.Airship, new Vector2(5.587f, -14.380f), SystemTypes.Security),
            new PositionData(MapType.Airship, new Vector2(10.299f, -15.976f), SystemTypes.Security),
            new PositionData(MapType.Airship, new Vector2(9.525f, -6.140f), SystemTypes.Electrical),
            new PositionData(MapType.Airship, new Vector2(12.350f, -8.936f), SystemTypes.Electrical),
            new PositionData(MapType.Airship, new Vector2(20.320f, -11.319f), SystemTypes.Electrical),
            new PositionData(MapType.Airship, new Vector2(15.165f, -8.914f), SystemTypes.Electrical),
            new PositionData(MapType.Airship, new Vector2(20.238f, -3.737f), SystemTypes.Electrical),
            new PositionData(MapType.Airship, new Vector2(25.542f, -10.184f), SystemTypes.Medical),
            new PositionData(MapType.Airship, new Vector2(22.631f, -5.230f), SystemTypes.Medical),
            new PositionData(MapType.Airship, new Vector2(29.078f, -6.721f), SystemTypes.Medical),
            new PositionData(MapType.Airship, new Vector2(33.088f, -6.173f), SystemTypes.Medical),
            new PositionData(MapType.Airship, new Vector2(30.512f, -3.428f), SystemTypes.CargoBay),
            new PositionData(MapType.Airship, new Vector2(28.812f, -1.591f), SystemTypes.CargoBay),
            new PositionData(MapType.Airship, new Vector2(39.333f, -3.572f), SystemTypes.CargoBay),
            new PositionData(MapType.Airship, new Vector2(35.955f, -3.113f), SystemTypes.CargoBay),
            new PositionData(MapType.Airship, new Vector2(37.461f, 0.096f), SystemTypes.CargoBay),
            new PositionData(MapType.Airship, new Vector2(35.166f, 3.203f), SystemTypes.CargoBay),
            new PositionData(MapType.Airship, new Vector2(33.733f, 7.286f), SystemTypes.Lounge),
            new PositionData(MapType.Airship, new Vector2(32.280f, 7.108f), SystemTypes.Lounge),
            new PositionData(MapType.Airship, new Vector2(30.837f, 7.338f), SystemTypes.Lounge),
            new PositionData(MapType.Airship, new Vector2(29.252f, 7.362f), SystemTypes.Lounge),
            new PositionData(MapType.Airship, new Vector2(27.143f, 9.829f), SystemTypes.Lounge),
            new PositionData(MapType.Airship, new Vector2(19.891f, 12.309f), SystemTypes.Records),
            new PositionData(MapType.Airship, new Vector2(17.294f, 7.815f), SystemTypes.Records),
            new PositionData(MapType.Airship, new Vector2(22.391f, 7.874f), SystemTypes.Records),
            new PositionData(MapType.Airship, new Vector2(18.012f, 5.057f), SystemTypes.Showers),
            new PositionData(MapType.Airship, new Vector2(22.682f, -2.088f), SystemTypes.Showers),
            new PositionData(MapType.Airship, new Vector2(25.921f, 0.546f), SystemTypes.Showers),
            new PositionData(MapType.Airship, new Vector2(21.072f, 2.706f), SystemTypes.Showers),
            new PositionData(MapType.Airship, new Vector2(16.579f, 2.465f), SystemTypes.MainHall),
            new PositionData(MapType.Airship, new Vector2(11.759f, 2.597f), SystemTypes.MainHall),
            new PositionData(MapType.Airship, new Vector2(8.870f, 2.556f), SystemTypes.MainHall),
            new PositionData(MapType.Airship, new Vector2(5.798f, 3.458f), SystemTypes.MainHall),
            new PositionData(MapType.Airship, new Vector2(5.751f, -3.484f), SystemTypes.MainHall),
            new PositionData(MapType.Airship, new Vector2(13.878f, 5.978f), SystemTypes.Office),
            new PositionData(MapType.Airship, new Vector2(24.091f, -16.289f), SystemTypes.Office),
            new PositionData(MapType.Airship, new Vector2(24.091f, -16.289f), SystemTypes.Office),
            new PositionData(MapType.Airship, new Vector2(24.091f, -16.289f), SystemTypes.Office)
        };

        public static List<PositionData> GetLocationsByMap(MapType Map) => MapLocations.Where(location => location.map == Map).ToList();
        public static List<PositionData> GetLocationByRoom(MapType Map, SystemTypes Room) => MapLocations.Where(location => location.room == Room && location.map == Map).ToList();

        // List Management
        public static List<PositionData> GetLocationsByMap(List<PositionData> Positons, MapType Map) => Positons.Where(location => location.map == Map).ToList();
        public static List<PositionData> GetLocationByRoom(List<PositionData> Positons, MapType Map, SystemTypes Room) => Positons.Where(location => location.room == Room && location.map == Map).ToList();

        public static PositionData GetRandomPosition(MapType Map) => GetLocationsByMap(Map)?.PickRandom();
        public static PositionData GetRandomPositionByRoom(MapType Map, SystemTypes Room) => GetLocationByRoom(Map, Room)?.PickRandom();
        public static PositionData GetRandomPosition(List<PositionData> Positions, MapType Map) => GetLocationsByMap(Positions, Map)?.PickRandom();
        public static PositionData GetRandomPositionByRoom(List<PositionData> Positions, MapType Map, SystemTypes Room) => GetLocationByRoom(Positions, Map, Room)?.PickRandom();
        public static MapType GetCurrentMap() {
            if (PlayerControl.GameOptions == null)
                return MapType.Skeld;

            return (MapType) PlayerControl.GameOptions.MapId;
        }
    }

    public sealed class PositionData {
        public readonly MapType map;
        public readonly Vector2 position;
        public readonly SystemTypes room;

        public PositionData(MapType map, Vector2 position, SystemTypes room) {
            this.map = map;
            this.position = position;
            this.room = room;
        }
    }
}
