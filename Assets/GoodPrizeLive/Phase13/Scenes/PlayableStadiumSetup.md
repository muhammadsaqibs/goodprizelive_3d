# Playable Stadium Setup

Create these GameObjects in the Stadium scene:

- GameManager
- CricketMatchController
- DeliverySystem
- BattingTiming
- BowlingController
- FieldingAI (one per fielder)
- CameraDirector
- MatchEventBus
- CommentaryAudio
- CrowdCards
- SponsorRotation
- TVScoreboard
- MobileHUD
- MainCamera

Gameplay loop:
1. Broadcast camera
2. Bowler starts run-up
3. Delivery
4. Batter timing
5. Ball travels
6. Fielders react
7. Result event
8. Scoreboard updates
9. Commentary/crowd/replay
10. Next ball
