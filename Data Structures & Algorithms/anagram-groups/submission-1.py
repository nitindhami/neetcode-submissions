class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # 🗄️ A dictionary where missing keys automatically default to an empty list
        anagram_map = defaultdict(list)

        for word in strs:
            # 🔤 Sort characters and join them back into a string key
            key = "".join(sorted(word))
            
            # ➕ Append the original word to the list for that key
            anagram_map[key].append(word)

        # 📦 Return all grouped lists
        return list(anagram_map.values())