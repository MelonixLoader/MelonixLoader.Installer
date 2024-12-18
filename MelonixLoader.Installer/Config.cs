﻿namespace MelonLoader.Installer;

internal static class Config
{
    public static Uri MelonWiki { get; private set; } = new("https://melonix.fun/");
    public static Uri Discord { get; private set; } = new("https://discord.gg/MNBMv8uvmS");
    public static Uri Github { get; private set; } = new("https://github.com/MelonixLoader");
    public static Uri Twitter { get; private set; } = new("https://x.com/lava_gang");
    public static string MelonLoaderReleasesApi { get; private set; } = "https://api.github.com/repos/LavaGang/MelonLoader/releases";
    public static string MelonLoaderBuildWorkflowApi { get; private set; } = "https://api.github.com/repos/LavaGang/MelonLoader/actions/workflows/5411546/runs?branch=alpha-development&event=push&status=success&per_page=5";
    public static string InstallerLatestReleaseApi { get; private set; } = "https://api.github.com/repos/LavaGang/MelonLoader.Installer/releases/latest";
    public static string CacheDir { get; private set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MelonixLoader Installer");
    public static string LocalZipCache { get; private set; } = Path.Combine(CacheDir, "Local Build");
    public static string GameListPath { get; private set; } = Path.Combine(CacheDir, "games.txt");

    public static string[] LoadGameList()
    {
        if (!File.Exists(GameListPath))
            return [];

        return File.ReadAllLines(GameListPath);
    }

    public static void SaveGameList(IEnumerable<string> gamePaths)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(GameListPath)!);
        File.WriteAllLines(GameListPath, gamePaths);
    }
}
