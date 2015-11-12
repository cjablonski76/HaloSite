namespace HaloSite.Models
{
	public class RootObject
	{
		public ResultClass[] Results { get; set; }
		public object Links { get; set; }
	}

	public class ResultClass
	{
		public string Id { get; set; }
		public string ResultCode { get; set; }
		public ArenaResult Result { get; set; }
	}

	public class ArenaResult
	{
		public ArenaStats ArenaStats { get; set; }
		public Playerid PlayerId { get; set; }
		public string SpartanRank { get; set; }
		public string Xp { get; set; }
	}

	public class ArenaStats
	{
		public ArenaPlaylistStat[] ArenaPlaylistStats { get; set; }
		public CsrClass HighestCsrAttained { get; set; }
		public ArenaGameBaseVariantStat[] ArenaGameBaseVariantStats { get; set; }
		public TopGameBaseVariant[] TopGameBaseVariants { get; set; }
		public string HighestCsrPlaylistId { get; set; }
		public string TotalKills { get; set; }
		public string TotalHeadshots { get; set; }
		public string TotalWeaponDamage { get; set; }
		public string TotalShotsFired { get; set; }
		public string TotalShotsLanded { get; set; }
		public WeaponStat WeaponWithMostKills { get; set; }
		public string TotalMeleeKills { get; set; }
		public string TotalMeleeDamage { get; set; }
		public string TotalAssassinations { get; set; }
		public string TotalGroundPoundKills { get; set; }
		public string TotalGroundPoundDamage { get; set; }
		public string TotalShoulderBashKills { get; set; }
		public string TotalShoulderBashDamage { get; set; }
		public string TotalGrenadeDamage { get; set; }
		public string TotalPowerWeaponKills { get; set; }
		public string TotalPowerWeaponDamage { get; set; }
		public string TotalPowerWeaponGrabs { get; set; }
		public string TotalPowerWeaponPossessionTime { get; set; }
		public string TotalDeaths { get; set; }
		public string TotalAssists { get; set; }
		public string TotalGamesCompleted { get; set; }
		public string TotalGamesWon { get; set; }
		public string TotalGamesLost { get; set; }
		public string TotalGamesTied { get; set; }
		public string TotalTimePlayed { get; set; }
		public string TotalGrenadeKills { get; set; }
		public MedalAward[] MedalAwards { get; set; }
		public Enemykill[] DestroyedEnemyVehicles { get; set; }
		public Enemykill[] EnemyKills { get; set; }
		public WeaponStat[] WeaponStats { get; set; }
		public Impulse[] Impulses { get; set; }
		public string TotalSpartanKills { get; set; }
	}

	public class WeaponId
	{
		public string StockId { get; set; }
		public string[] Attachments { get; set; }
	}

	public class ArenaPlaylistStat
	{
		public string PlaylistId { get; set; }
		public string MeasurementMatchesLeft { get; set; }
		public CsrClass HighestCsr { get; set; }
		public CsrClass Csr { get; set; }
		public string TotalKills { get; set; }
		public string TotalHeadshots { get; set; }
		public string TotalWeaponDamage { get; set; }
		public string TotalShotsFired { get; set; }
		public string TotalShotsLanded { get; set; }
		public WeaponStat WeaponWithMostKills { get; set; }
		public string TotalMeleeKills { get; set; }
		public string TotalMeleeDamage { get; set; }
		public string TotalAssassinations { get; set; }
		public string TotalGroundPoundKills { get; set; }
		public string TotalGroundPoundDamage { get; set; }
		public string TotalShoulderBashKills { get; set; }
		public string TotalShoulderBashDamage { get; set; }
		public string TotalGrenadeDamage { get; set; }
		public string TotalPowerWeaponKills { get; set; }
		public string TotalPowerWeaponDamage { get; set; }
		public string TotalPowerWeaponGrabs { get; set; }
		public string TotalPowerWeaponPossessionTime { get; set; }
		public string TotalDeaths { get; set; }
		public string TotalAssists { get; set; }
		public string TotalGamesCompleted { get; set; }
		public string TotalGamesWon { get; set; }
		public string TotalGamesLost { get; set; }
		public string TotalGamesTied { get; set; }
		public string TotalTimePlayed { get; set; }
		public string TotalGrenadeKills { get; set; }
		public MedalAward[] MedalAwards { get; set; }
		public Enemykill[] DestroyedEnemyVehicles { get; set; }
		public Enemykill[] EnemyKills { get; set; }
		public WeaponStat[] WeaponStats { get; set; }
		public Impulse[] Impulses { get; set; }
		public string TotalSpartanKills { get; set; }
	}

	public class CsrClass
	{
		public string Tier { get; set; }
		public string DesignationId { get; set; }
		public string Csr { get; set; }
		public string PercentToNextTier { get; set; }
		public string Rank { get; set; }
	}

	public class MedalAward
	{
		public string MedalId { get; set; }
		public string Count { get; set; }
	}

	public class Enemy
	{
		public string BaseId { get; set; }
		public string[] Attachments { get; set; }
	}

	public class Enemykill
	{
		public Enemy Enemy { get; set; }
		public string TotalKills { get; set; }
	}

	public class WeaponStat
	{
		public WeaponId WeaponId { get; set; }
		public string TotalShotsFired { get; set; }
		public string TotalShotsLanded { get; set; }
		public string TotalHeadshots { get; set; }
		public string TotalKills { get; set; }
		public string TotalDamageDealt { get; set; }
		public string TotalPossessionTime { get; set; }
	}

	public class Impulse
	{
		public string Id { get; set; }
		public string Count { get; set; }
	}

	public class ArenaGameBaseVariantStat
	{
		public FlexibleStats FlexibleStats { get; set; }
		public string GameBaseVariantId { get; set; }
		public string TotalKills { get; set; }
		public string TotalHeadshots { get; set; }
		public string TotalWeaponDamage { get; set; }
		public string TotalShotsFired { get; set; }
		public string TotalShotsLanded { get; set; }
		public WeaponStat WeaponWithMostKills { get; set; }
		public string TotalMeleeKills { get; set; }
		public string TotalMeleeDamage { get; set; }
		public string TotalAssassinations { get; set; }
		public string TotalGroundPoundKills { get; set; }
		public string TotalGroundPoundDamage { get; set; }
		public string TotalShoulderBashKills { get; set; }
		public string TotalShoulderBashDamage { get; set; }
		public string TotalGrenadeDamage { get; set; }
		public string TotalPowerWeaponKills { get; set; }
		public string TotalPowerWeaponDamage { get; set; }
		public string TotalPowerWeaponGrabs { get; set; }
		public string TotalPowerWeaponPossessionTime { get; set; }
		public string TotalDeaths { get; set; }
		public string TotalAssists { get; set; }
		public string TotalGamesCompleted { get; set; }
		public string TotalGamesWon { get; set; }
		public string TotalGamesLost { get; set; }
		public string TotalGamesTied { get; set; }
		public string TotalTimePlayed { get; set; }
		public string TotalGrenadeKills { get; set; }
		public MedalAward[] MedalAwards { get; set; }
		public Enemykill[] DestroyedEnemyVehicles { get; set; }
		public Enemykill[] EnemyKills { get; set; }
		public WeaponStat[] WeaponStats { get; set; }
		public Impulse[] Impulses { get; set; }
		public string TotalSpartanKills { get; set; }
	}

	public class FlexibleStats
	{
		public StatCount[] StatCounts { get; set; }
		public StatCount[] ImpulseStatCounts { get; set; }
		public TimeLapseClass[] Timelapses { get; set; }
		public TimeLapseClass[] ImpulseTimelapses { get; set; }
	}

	public class StatCount
	{
		public string Id { get; set; }
		public string Count { get; set; }
	}

	public class TimeLapseClass
	{
		public string Id { get; set; }
		public string TimeLapse { get; set; }
	}

	public class TopGameBaseVariant
	{
		public string GameBaseVariantRank { get; set; }
		public string NumberOfMatchesCompleted { get; set; }
		public string GameBaseVariantId { get; set; }
		public string NumberOfMatchesWon { get; set; }
	}

	public class Playerid
	{
		public string GamerTag { get; set; }
		public object Xuid { get; set; }
	}

}
