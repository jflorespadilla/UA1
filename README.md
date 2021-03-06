#   U A 1  

Project 1 of the "Unity in Action" text book. This is meant to be a review on how to make Unity programs.

#### Making Edits

To create a branch do the following:

>While on Master
```
$git pull
```
>This will ensure that you are up to date with the latest master code.
>Next do:

```
$git checkout -b myFeature
```

>This will create your and switch you to your feature branch.
>Once you have made your changes simply commit and push to your branch.

```
$git add .
$git commit -m "My feature notes"
$git push origin myFeature
```

#### Merging

>Be sure that your branch is clean before moving forward.
>Once you are ready to merge your code to the main branch simply run the following commands:

```
$git checkout master
$git merge myFeature
$git push origin master
```

>Then you can locally delete your branch:

```
$git branch -d myFeature
```
