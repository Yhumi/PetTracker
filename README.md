# PetTracker

A fun plugin to allow full (consensual) tracking of a player and what they're up to.

## Features

Track's player's:
- Character Online Status
- Current Location
- Are they in combat?
- World they're logged into.
- Party List
	(**Please note, party list will show initials and jobs only.**)
- Time since last death and deaths in current instance where applicable.

## Safety Precautions
The plugin operates on consent on two levels. 
One between the server and the client, no data will be sent to the server without the client/current user being opted into sending it.
The second being between players, no data can be shared between players without mutual consent between players.

If you enable tracking and give someone your code, they can track you.

### Data Deletion
Disabling data sharing will delete all related data to your character from the server except the user.
Deleteing your PetTracker account will also delete the user, requiring you to sign back up again to a server to use the plugin.

## Setup & How It Works

The plugin REQUIRES a server to work. The server software is provided as-is in this repository.
When first installing the plugin you will be prompted to fill out a set of server details:
- Server IP
- Server Port

Once entered, it'll ping out trying to find the server and if it gets a response, it'll then attempt to create a user for your current logged in Character.

**AT THIS POINT THE PLUGIN IS NOT TRACKING YOU. THERE IS NO TRACKING SENT UNTIL YOU CONSENT TO THE DATA BEING SENT.**
It will always create a user as this is how it tracks **consent between players.** 
Once created, you will be given a unique user Id, this is for you to share with people you trust.

In order to **consent** to the server storing information on you, you must go into the plugin settings and enable player metrics being stored.
At this point data will start being sent to the server and stored against your user, but nobody will be able to see this yet.

In order to **consent** to another player seeing your data, you must send them your personal Id, and them send you theirs.
Please note: **When a player has your unique Id for the server they WILL be able to track you.**

Please use this with only **SERVERS and PEOPLE** you trust. Both of them. 
This spills so much live data about your character. Its a serious in-game stalking risk and should be taken extremely seriously.

## Roadmap

Current future plans:
- Support mutliple servers simultaneously.
- Support more tracking data points.